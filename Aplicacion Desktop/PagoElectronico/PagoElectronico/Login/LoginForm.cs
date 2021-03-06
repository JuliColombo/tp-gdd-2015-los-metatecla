﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox_username.Text;
            string password = textBox_password.Text;

            if (PagoElectronico.DB.UsuarioDB.autentificar(usuario,password))
            {
                int intento = numerosDeIntentos(usuario);
                if (intento < 4)
                {
                  
                    ponerIntentosEnCero(intento, usuario);

                    loggear(usuario, "efectivo",0, "");

                    int idUsuario = DB.UsuarioDB.getId(usuario);
                    List<int> idRoles = DB.RolDB.getRolesUsuario(idUsuario);
                    if (idRoles.Count > 1)
                    {
                        List<PagoElectronico.Dominio.Rol> roles = new List<PagoElectronico.Dominio.Rol>();
                        foreach (int idRol in idRoles)
                        {
                            roles.Add(DB.RolDB.getRol(idRol));
                        }

                        SeleccionRolForm slecrol = new SeleccionRolForm(roles, idUsuario);
                        slecrol.ShowDialog();
                    }
                    else
                    {
                        PagoElectronico.Dominio.Rol rol = DB.RolDB.getRol(idRoles[0]);
                        if (rol.habilitado)
                        {
                            Form f = new PantallaPrincipal(idUsuario, idRoles[0]);
                            f.ShowDialog();
                            this.Close();
                        }
                        else { MessageBox.Show("El rol de la cuenta se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    //TODO Habria que abrir otra pantalla con los roles y funcionalidades
                }
                else
                {
                    ventanaDeError("Esta inhabilitado.");
                    
                }
                
            }
            else
            {
    
                if (existeUsuario(usuario))
                {
                    int intento = numerosDeIntentos(usuario);

                    agregarIntentoFallido(usuario);

                    ventanaDeError("Contraseña incorrecta.");
                    loggear(usuario, "fallido",intento+1, "");


                    if (intento == 3)
                    {
                        inhabilitarUsuario(usuario);

                        ventanaDeError("Esta inhabilitado.");
                        
                    }
                }
                else
                {
                    ventanaDeError("No existe ese nombre de usuario.");
                    
                }
      

            }


        }

        /*********************** AUXILIARES ****************************/

        private void loggear(string usuario, string tipo_intento, int numero_intento, string info_extra)
        {
            string log;

            if (info_extra == "")
            {
                if (tipo_intento == "fallido")
                {
                    log = "El usuario " + usuario + " tuvo un intento " + tipo_intento + " numero: " + numero_intento.ToString();
                }
                else
                {
                    log = "El usuario " + usuario + " tuvo un intento " + tipo_intento;
                }
            }
            else
            {
                log = "El usuario " + usuario + " " + info_extra;
            }


            DateTime date = DateTime.Now;
            string fecha_y_hora = date.ToString();

            PagoElectronico.DB.UsuarioDB.insertarLog("[ "+fecha_y_hora+" ] "+log);
        }


        private void ventanaDeError(String error)
        {
            Form f = new PagoElectronico.UI.ErrorForm(error);
            f.ShowDialog();
        }

        private void ponerIntentosEnCero(int intento, string usuario)
        {
            if (intento > 0)
            {
                PagoElectronico.DB.UsuarioDB.modificarNumeroDeIntentos(usuario, 0);
            }
        }

        private void inhabilitarUsuario(string usuario)
        {
            PagoElectronico.DB.UsuarioDB.inhabilitarUsuario(usuario);

            loggear(usuario, "",0, "esta inhabilitado");
        }

        private int numerosDeIntentos(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.numeroDeIntentos(usuario);
        }

        private bool existeUsuario(string usuario)
        {
            return PagoElectronico.DB.UsuarioDB.existe(usuario);
        }

        private void agregarIntentoFallido(string usuario)
        {
            PagoElectronico.DB.UsuarioDB.agregarIntentoFallido(usuario);
        }

        
    }
}

