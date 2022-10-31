using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestTdeP
{
    
    public partial class frmLibrodeClases : Form
    {
        public frmLibrodeClases()
        {
            InitializeComponent();

            StreamReader ListaSecreta_edit = new StreamReader(@"../../Alumnos/ListaSecreta.txt");//se abre el documento de lista para 
            string Verif_line = ListaSecreta_edit.ReadLine();
            while (Verif_line != null) //Mientras haya lineas con texto, se ejecutará esta acción
            {
                string[] secretData = Verif_line.Split(';');
                dgvListadeClases.Rows.Add(secretData[0], secretData[1]);
                Verif_line = ListaSecreta_edit.ReadLine();
            }
            ListaSecreta_edit.Close();

        }
        public bool ValidaRut(string RutT)
        {
            bool validacion = false;
            try
            {
                RutT = RutT.ToUpper();
                RutT = RutT.Replace(".", "");
                RutT = RutT.Replace("-", "");
                int aux = int.Parse(RutT.Substring(0, RutT.Length - 1));
                char dv = char.Parse(RutT.Substring(RutT.Length - 1, 1));

                int m = 0, s = 1;
                for (; aux != 0; aux /= 10)
                {
                    s = (s + aux % 10 * (9 - m++ % 6)) % 11;

                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            { 
            
            }
            return validacion;
        }
        private string ActualizarDetalles() //Función que actualiza el textbox de detalles
        {
            string Selected_Alumno = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString(); //Se identifica el Rut del Alumno en el Data grid view
            
            try
            {
                StreamReader ListaSecreta_data = new StreamReader(@"../../Alumnos/Datos/" + Selected_Alumno + ".txt");
                StreamReader ListaSecreta_notas = new StreamReader(@"../../Alumnos/Notas/" + Selected_Alumno + ".txt");
                StreamReader ListaSecreta_obs = new StreamReader(@"../../Alumnos/Observaciones/"+ Selected_Alumno + "/" + Selected_Alumno + ".txt");
                txtDetalles.Text = ListaSecreta_data.ReadToEnd() + ListaSecreta_notas.ReadToEnd() + ListaSecreta_obs.ReadToEnd();
                ListaSecreta_data.Close();
                ListaSecreta_notas.Close();
                ListaSecreta_obs.Close();
            }
            catch (Exception)
            {
                try
                {
                    MessageBox.Show("El Alumno no tiene registro de notas, por favor llene los campos correspondientes", "Error");
                    StreamWriter ListaSecreta_notas = new StreamWriter(@"../../Alumnos/Notas/" + Selected_Alumno + ".txt");
                    StreamWriter ListaSecreta_obs = new StreamWriter(@"../../Alumnos/Observaciones/" + Selected_Alumno + "/" + Selected_Alumno + ".txt");
                    ListaSecreta_notas.Close();
                    ListaSecreta_obs.Close();
                    StreamReader ListaSecreta_data = new StreamReader(@"../../Alumnos/Datos/" + Selected_Alumno + ".txt");
                    txtDetalles.Text = ListaSecreta_data.ReadToEnd();
                    ListaSecreta_data.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR actualizar detalles");
                }
                }


            return null;
        }
        public string LeerTabla(string texto) //Lee el documento ListaSecreta y lo traspasa a la Tabla
        {

            StreamReader ListaSecreta_edit = new StreamReader(texto);
            string Verif_line = ListaSecreta_edit.ReadLine();
            while (Verif_line != null) //Mientras haya lineas con texto, se ejecutará esta acción
            {
                string[] secretData = Verif_line.Split(';');
                dgvListadeClases.Rows.Add(secretData[0], secretData[1]);
                Verif_line = ListaSecreta_edit.ReadLine();
            }
            ListaSecreta_edit.Close();

            return null;
        }
        public bool CoincidenciaRUT(string ubicacion_texto, string RUT) //Lee el documento ListaSecreta en busca de coincidencia de campos
        {
            bool repetido = false;
            StreamReader ListaSecreta = new StreamReader(ubicacion_texto);
            string Verif_line = ListaSecreta.ReadLine();
            while (Verif_line != null) //Mientras haya lineas con texto, se ejecutará esta acción
            {
                string[] secretData = Verif_line.Split(';');
                if (secretData[1] == RUT) //Si existe un campo de rut repetido, el programa no ingresará los datos.
                {
                    repetido = true;
                }

                Verif_line = ListaSecreta.ReadLine();
            }
            ListaSecreta.Close();

            return repetido;
        }
        private void dgvListadeClases_SelectionChanged(object sender, EventArgs e)
        {

            txtRUT_notas.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString();
            txtRUT_reemplazarNotas.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString();
            txtRUT_quitarObservacion.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString();
            txtNombre_quitarAlumno.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[0].Value.ToString();
            txtRUT_eliminar.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString();
            ActualizarDetalles();
        }
        public void SaveToFile(string strPath)
        {
            List<string> lstFilas = new List<string>();
            foreach (DataGridViewRow row in dgvListadeClases.Rows)
            {
                string Linea = "";
                if (row.Index == dgvListadeClases.Rows.Count - 1)
                {
                    break;
                }
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        Linea += " ";
                    }
                    else
                    {
                        Linea += cell.Value.ToString();
                        Linea += ";";
                    }
                }
                lstFilas.Add(Linea.TrimEnd(';'));
            }
            if (File.Exists(strPath)) File.Delete(strPath);
            File.WriteAllLines(strPath, lstFilas);
        }
        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            //propiedades de Alumno: NombreAlumno,NacAlumno, EdadAlumno, RUTAlumno


            //Instanciacion de la clase Alumno
            Alumno Alumni = new Alumno(); //<-----------------------------
            //Instanciacion de la clase ALumno


            Alumni.NombreAlumno = txtNombre.Text;
            Alumni.NacAlumno = ("["+txtDia.Text + "/" + txtMes.Text + "/" + txtAño.Text+"]");

            if (ValidaRut(txtRUT.Text))
            {
                Alumni.RUT_Alumno = txtRUT.Text;
                if (CoincidenciaRUT(@"../../Alumnos/ListaSecreta.txt", txtRUT.Text))
                {
                    MessageBox.Show("El rut ya está registrado", "ERROR");
                }
                else
                {

                    StreamWriter Lista_Control = new StreamWriter(@"../../Alumnos/ListaSecreta.txt", true);
                    Lista_Control.WriteLine(Alumni.NombreAlumno + ";" + Alumni.RUT_Alumno);
                    Lista_Control.Close();
                    Directory.CreateDirectory(@"../../Alumnos/Observaciones/" + Alumni.RUT_Alumno);

                    StreamWriter Ingreso_Alumno = new StreamWriter(@"../../Alumnos/Datos/" + Alumni.RUT_Alumno + ".txt"); //Se crea el documento con el Rut del alumno
                    StreamWriter Ingreso_Alumno_notas = new StreamWriter(@"../../Alumnos/Notas/" + Alumni.RUT_Alumno + ".txt"); //crea el documento que almacenará las notas
                    StreamWriter Ingreso_Alumno_obs = new StreamWriter(@"../../Alumnos/Observaciones/" + Alumni.RUT_Alumno + "/" + Alumni.RUT_Alumno + ".txt");//crea el documento que almacenará las observaciones
                    Ingreso_Alumno.WriteLine("[NOMBRE]: " + Alumni.NombreAlumno); //Nombre del Alumno
                    Ingreso_Alumno.WriteLine("[RUT]: " + Alumni.RUT_Alumno); //RUT Alumno
                    Ingreso_Alumno.WriteLine("[FECHA DE NACIMIENTO]: " + Alumni.NacAlumno); //Nacimiento Alumno
                    try
                    {
                        Ingreso_Alumno.WriteLine("[EDAD]: " + Alumni.calculaEdad(int.Parse(txtAño.Text), int.Parse(txtMes.Text), int.Parse(txtDia.Text)));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El formato de fecha es incorrecto");
                        Ingreso_Alumno.Close();
                    }
                    Ingreso_Alumno.WriteLine(" ");
                    Ingreso_Alumno.Close();
                    Ingreso_Alumno_notas.Close();
                    Ingreso_Alumno_obs.Close();

                    txtNombre.Clear();
                    txtDia.Clear();
                    txtMes.Clear();
                    txtAño.Clear();
                    txtRUT.Clear();

                    dgvListadeClases.Rows.Clear();

                    LeerTabla(@"../../Alumnos/ListaSecreta.txt");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un rut válido", "ERROR");
            }
            } //Ingresar Alumno
            private void btnNotas_Click(object sender, EventArgs e)
        {
            StreamReader Leer_Notas = new StreamReader(@"../../Alumnos/Notas/" + txtRUT_notas.Text + ".txt");
            string nota_leida = Leer_Notas.ReadLine();
            if (nota_leida != null)
            {
                MessageBox.Show("El alumno ya registra notas", "ERROR");
                Leer_Notas.Close();
            }
            else
            {
                Leer_Notas.Close();
                //string prom = ("[PROMEDIO]: " + Calc_promedio(@"../../Alumnos/notas/" + txtRUT_notas.Text + ".txt"));
                StreamWriter Ingreso_Notas = new StreamWriter(@"../../Alumnos/Notas/" + txtRUT_notas.Text + ".txt", true);
                Ingreso_Notas.WriteLine("[Nota 1]:" + txtNota1.Text);
                Ingreso_Notas.WriteLine("[Nota 2]:" + txtNota2.Text);
                Ingreso_Notas.WriteLine("[Nota 3]:" + txtNota3.Text);
                //Promedio
                try
                {
                    double suma = double.Parse(txtNota1.Text) + double.Parse(txtNota2.Text) + double.Parse(txtNota3.Text);
                    double prom = suma / 3;
                    Ingreso_Notas.WriteLine("[PROMEDIO]: " + prom.ToString("0.##"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR de notas");
                }

                Ingreso_Notas.WriteLine(" ");
                Ingreso_Notas.Close();
                txtNota1.Clear();
                txtNota2.Clear();
                txtNota3.Clear();
                ActualizarDetalles();
            }
            } //Ingresar Notas
        private void btnObservacion_Click(object sender, EventArgs e) //Ingresar Observación
        {

            txtRUT_notas.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString();
            StreamWriter Ingreso_Observacion = new StreamWriter(@"../../Alumnos/Observaciones/" + txtRUT_notas.Text + "/" + txtRUT_notas.Text + ".txt",true);
            Ingreso_Observacion.WriteLine(txtTitulo_observacion.Text);
            Ingreso_Observacion.WriteLine(txtDia_Obs.Text + "/" + txtMes_Obs.Text + "/" + txtAño_obs.Text);
            
            Ingreso_Observacion.WriteLine(txtObservacion.Text);
            Ingreso_Observacion.Close();
            
            txtTitulo_observacion.Clear();
            txtObservacion.Clear();
            txtDia_Obs.Clear();
            txtMes_Obs.Clear();
            txtAño_obs.Clear();
            
            ActualizarDetalles();
        }
        private void btnReemplazar_nota_Click(object sender, EventArgs e)
        {

            StreamWriter Ingreso_Notas = new StreamWriter(@"../../Alumnos/Notas/" + txtRUT_notas.Text + ".txt");
            Ingreso_Notas.WriteLine("[Nota 1]:" + txtNota1_reemplazo.Text);
            Ingreso_Notas.WriteLine("[Nota 2]:" + txtNota2_reemplazo.Text);
            Ingreso_Notas.WriteLine("[Nota 3]:" + txtNota3_reemplazo.Text);
            //Promedio
            try
            {
                double suma = double.Parse(txtNota1_reemplazo.Text) + double.Parse(txtNota2_reemplazo.Text) + double.Parse(txtNota3_reemplazo.Text);
                double prom = suma / 3;
                Ingreso_Notas.WriteLine("[PROMEDIO]: " + prom.ToString("0.##"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR reemplazo de notas");
            }

            Ingreso_Notas.WriteLine(" ");
            Ingreso_Notas.Close();

            txtNota1_reemplazo.Clear();
            txtNota2_reemplazo.Clear();
            txtNota3_reemplazo.Clear();
            ActualizarDetalles();
        } //Reemplazar notas
        private void txtDia_MouseClick(object sender, MouseEventArgs e)
        {
            txtDia.Clear();
        }
        private void txtMes_MouseClick(object sender, MouseEventArgs e)
        {
            txtMes.Clear();
        }
        private void txtAño_MouseClick(object sender, MouseEventArgs e)
        {
            txtAño.Clear();
        }
        private void txtRUT_MouseClick(object sender, MouseEventArgs e)
        {
            txtRUT.Clear();
        }
        private void txtRUT_notas_MouseClick(object sender, MouseEventArgs e)
        {
            txtRUT_notas.Clear();
        }
        private void txtRUT_reemplazarNotas_MouseClick(object sender, MouseEventArgs e)
        {
            txtRUT_reemplazarNotas.Clear();
        }
        private void txtRUT_quitarObservacion_MouseClick(object sender, MouseEventArgs e)
        {
            txtRUT_quitarObservacion.Clear();
        }
        private void txtRUT_eliminar_MouseClick(object sender, MouseEventArgs e)
        {
            txtRUT_eliminar.Clear();
        }
        private void txtAño_obs_MouseClick(object sender, MouseEventArgs e)
        {
            txtAño_obs.Clear();
        }
        private void txtMes_Obs_MouseClick(object sender, MouseEventArgs e)
        {
            txtMes_Obs.Clear();
        }
        private void txtDia_Obs_MouseClick(object sender, MouseEventArgs e)
        {
            txtDia_Obs.Clear();
        }
        private void chkReemplazar_notas_CheckedChanged(object sender, EventArgs e)
        {

            
            if (grpReemplazar_nota.Enabled == true)
            {
                grpReemplazar_nota.Enabled = false;
            }
            else
            {
                grpReemplazar_nota.Enabled = true;
            }
        }
        private void chkQuitar_observacion_CheckedChanged(object sender, EventArgs e)
        {

            if (grpObservacion.Enabled == true)
            {
                grpObservacion.Enabled = false;
            }
            else
            {
                grpObservacion.Enabled = true;
            }
             
        }
        private void chkQuitar_alumno_CheckedChanged(object sender, EventArgs e)
        {
            if (grpEliminar.Enabled == true)
            {
                grpEliminar.Enabled = false;
            }
            else
            {
                grpEliminar.Enabled = true;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtRUT_eliminar.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString(); //Rut Seleccionado a eliminar

            File.Delete(@"../../Alumnos/Notas" + txtRUT_eliminar.Text + ".txt");
            File.Delete(@"../../Alumnos/Datos" + txtRUT_eliminar.Text + ".txt");
            File.Delete(@"../../Alumnos/Observaciones/" + txtRUT_eliminar.Text + "/" + txtRUT_eliminar.Text + ".txt");
            StreamReader eliminar_lista = new StreamReader(@"../../Alumnos/ListaSecreta.txt");
            string Verif_line = eliminar_lista.ReadLine();
            string[] secretData = Verif_line.Split(';');
            int indx = Array.IndexOf(secretData, txtRUT_eliminar.Text);
            secretData = secretData.Where((source, index) => index != indx).ToArray();
            Verif_line = eliminar_lista.ReadLine();
            eliminar_lista.Close();
            

            dgvListadeClases.Rows.RemoveAt(dgvListadeClases.CurrentRow.Index);
            SaveToFile(@"../../Alumnos/ListaSecreta.txt");
        }
        private void txtObservacion_MouseClick(object sender, MouseEventArgs e)
        {

            txtDia_Obs.Text = DateTime.Today.ToString("dd");
            txtMes_Obs.Text = DateTime.Today.ToString("MM");
            txtAño_obs.Text = DateTime.Today.ToString("yyyy");
            
        }

        private void btnEliminar_observacion_Click(object sender, EventArgs e)
        {
            txtRUT_eliminar.Text = this.dgvListadeClases.Rows[dgvListadeClases.CurrentRow.Index].Cells[1].Value.ToString(); //Rut Seleccionado a eliminar
            File.Delete(@"../../Alumnos/Observaciones/" + txtRUT_eliminar.Text + "/" + txtRUT_eliminar.Text + ".txt");
        }
    }
}
