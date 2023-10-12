﻿using AppMediaPlayer.Controller;
using AppMediaPlayer.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer
{
    public partial class Main : Form
    {
        bool Play = true;
        public Main()
        {
            InitializeComponent();
        }

        void Change_Form(Panel painel, Form form)
        {
            painel.Controls.Clear();
            form.TopLevel = false;
            painel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Show();
        }


        //Botão musicas
        private void lblMusicas_Click(object sender, EventArgs e)
        {
            Form musicas = new Pages.Musicas();
            Change_Form(pnlMain, musicas);
            txtTitulo.Text = "Musicas";
        }
        private void lblMusicas_MouseEnter(object sender, EventArgs e)
        {
            lblMusicas.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblMusicas_MouseLeave(object sender, EventArgs e)
        {
            lblMusicas.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão PlayLists
        private void lblPlayList_Click(object sender, EventArgs e)
        {
            Form playlist = new Pages.Playlists();
            Change_Form(pnlMain, playlist);
            txtTitulo.Text = "Playlists";
        }
        private void lblPlayList_MouseEnter(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblPlayList_MouseLeave(object sender, EventArgs e)
        {
            lblPlayList.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

       
        private void lblRecomendados_MouseEnter(object sender, EventArgs e)
        {
            lblRecomendados.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Underline);
        }
        private void lblRecomendados_MouseLeave(object sender, EventArgs e)
        {
            lblRecomendados.Font = new Font(lblMusicas.Font.Name, lblMusicas.Font.Size, FontStyle.Regular);
        }

        //Botão Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(Play)
            {
                btnPlay.Image = Properties.Resources.Pause;
                Play = false;
            }
            else
            {
                btnPlay.Image = Properties.Resources.Play;
                Play = true;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair da sua conta e voltar à tela inicial?", "Retorno à Tela Inicial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                FormController.ShowForm(this, new Contas());

            return;
        }
    }
}