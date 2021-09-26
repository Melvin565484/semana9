using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareasemana9
{
    class Instructor
    {
        //Metodo de propiedad
        private string _Nameid;
        private string _Direction;
        private string _Horarios;
        private string _Certification;

        //Metodo de propiedad autoimplementada 
        public int _phonenumber{ get; set; }

        //Metodo constructor
        public Instructor() //Metodo vacio 
        { }

        //Metodo de sobrecarga de constructor 
        public Instructor(string Nameid, string Direction, string Horarios, string Certification, int Phonenumber)
        {
            _Nameid = Nameid;
            _Direction = Direction;
            _Horarios = Horarios
            _Certification = Certification;
            _Phonenumber = Phonenumber;
        }

        //Id instructor
        public string getNameid()
        {
            return _Nameid;
        }

        public void setNameid(string Nameid)
        {
            _Nameid = Nameid;
        }


        //direccion
        public string getDirection()
        {
            return _Direction;
        }

        public void setDirection(string Direction)
        {
            _Direction = Direction;
        }

        //Horarios de clases
        public string getHorarios()
        {
            return _Horarios;
        }

        public void setHorarios(string Horarios)
        {
            _Horarios = Horarios;
        }

        //Certificacion para hacer constar las capacidades del instructor
        public string getCertification()
        {
            return _Certification;
        }

        public void setCertification(string Certification)
        {
            _Phonenumber = Certification;
        }

        //numero de instructor para realizar consulta o inscibirse a un curso
        public string getPhonenumber()
        {
            return _Phonenumber;
        }

        public void setPhonenumber(string Phonenumber)
        {
            _Phonenumber = Phonenumber;
        }

        //Metodo para mostrar información 
        public string getBankInfo()
        {
            return "ID:   " + _Nameid + "Direccion:  " + _Direction + "Horarios:  " + _Horarios + "Certificacion:  " + _Certification+ "Numero de telefono:  " + _Phonenumber;

        }

    }
}

    

