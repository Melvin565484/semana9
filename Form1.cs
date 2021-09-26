using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareasemana9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creamos la instancia del banco
            Instructor Instructor = new Instructor();
            //Creamos un objeto

            //Asignar valores a las propiedades
            Instructor.setNameid("");
            Instructor.setDirection("");
            Instructor.setHorarios("");
            Instructor.setCertification("");


            //Asignar valores a propiedades autoimplementadas 

            Instructor._Phonenumber = ("");
            //Mostrar datos del banco


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            //Instancia de la clase utilizando constructores 

            //Utilizando constructor vacio 
            Instructor Instructor = new Instructor();
            Instructor.setNameid(Convert.Tostring(txtID.Text));
            Instructor.setDirection(txtDirection.Text);
            Instructor.setHorarios(txtHorarios.Text);
            Instructor.setCertification ( txtCertificacion.Text);
            Instructor._Phonenumber = txtPhonenumber.Text;


            //Constructor que inicializa todas las propiedades
            Instructor Instructor1 = new Instructor(Convert.ToInt32(txtID.Text),
                txtDirection.Text, txtHorarios.Text, txtCertificacion.Text, txtPhonenumber.Text);


            //agregar los datos a listbox
            lstInstructorInfo.Items.Add("Mediante constructor vacío: " + Instructor.getInstructorInfo());
            lstInstructorInfo.Items.Add("Mediante constructor inicializando las propiedaandes: " +Instructor.getInstructorInfo());
        }
    }

}








    

