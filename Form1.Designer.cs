
namespace TestTdeP
{
    partial class frmLibrodeClases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibrodeClases));
            this.grpNuevoIngreso = new System.Windows.Forms.GroupBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.btnNuevoIngreso = new System.Windows.Forms.Button();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.lblNac = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRUT = new System.Windows.Forms.Label();
            this.grpNotas = new System.Windows.Forms.GroupBox();
            this.txtRUT_notas = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblRUT_notas = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.txtNombre_quitarAlumno = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtRUT_eliminar = new System.Windows.Forms.TextBox();
            this.lblNombre_eliminar = new System.Windows.Forms.Label();
            this.lblRUT_eliminar = new System.Windows.Forms.Label();
            this.grpObservacion = new System.Windows.Forms.GroupBox();
            this.btnEliminar_observacion = new System.Windows.Forms.Button();
            this.txtRUT_quitarObservacion = new System.Windows.Forms.TextBox();
            this.lblRUT_quitarObservacion = new System.Windows.Forms.Label();
            this.grpReemplazar_nota = new System.Windows.Forms.GroupBox();
            this.txtNota3_reemplazo = new System.Windows.Forms.TextBox();
            this.btnReemplazar_nota = new System.Windows.Forms.Button();
            this.lblnota3_reemplazar = new System.Windows.Forms.Label();
            this.txtRUT_reemplazarNotas = new System.Windows.Forms.TextBox();
            this.txtNota2_reemplazo = new System.Windows.Forms.TextBox();
            this.lblRUT_reemplazarNotas = new System.Windows.Forms.Label();
            this.lblnota2_reemplazar = new System.Windows.Forms.Label();
            this.lblnota1_reemplazar = new System.Windows.Forms.Label();
            this.txtNota1_reemplazo = new System.Windows.Forms.TextBox();
            this.chkReemplazar_notas = new System.Windows.Forms.CheckBox();
            this.chkQuitar_observacion = new System.Windows.Forms.CheckBox();
            this.chkQuitar_alumno = new System.Windows.Forms.CheckBox();
            this.dgvListadeClases = new System.Windows.Forms.DataGridView();
            this.NombreAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnObservacion = new System.Windows.Forms.Button();
            this.txtTitulo_observacion = new System.Windows.Forms.TextBox();
            this.lblTitulo_observacion = new System.Windows.Forms.Label();
            this.txtDia_Obs = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtMes_Obs = new System.Windows.Forms.TextBox();
            this.txtAño_obs = new System.Windows.Forms.TextBox();
            this.grpObservaciones = new System.Windows.Forms.GroupBox();
            this.grpNuevoIngreso.SuspendLayout();
            this.grpNotas.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            this.grpObservacion.SuspendLayout();
            this.grpReemplazar_nota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadeClases)).BeginInit();
            this.grpObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNuevoIngreso
            // 
            this.grpNuevoIngreso.Controls.Add(this.txtAño);
            this.grpNuevoIngreso.Controls.Add(this.txtMes);
            this.grpNuevoIngreso.Controls.Add(this.txtDia);
            this.grpNuevoIngreso.Controls.Add(this.btnNuevoIngreso);
            this.grpNuevoIngreso.Controls.Add(this.txtRUT);
            this.grpNuevoIngreso.Controls.Add(this.lblNac);
            this.grpNuevoIngreso.Controls.Add(this.txtNombre);
            this.grpNuevoIngreso.Controls.Add(this.lblNombre);
            this.grpNuevoIngreso.Controls.Add(this.lblRUT);
            this.grpNuevoIngreso.Location = new System.Drawing.Point(733, 40);
            this.grpNuevoIngreso.Name = "grpNuevoIngreso";
            this.grpNuevoIngreso.Size = new System.Drawing.Size(210, 125);
            this.grpNuevoIngreso.TabIndex = 10;
            this.grpNuevoIngreso.TabStop = false;
            this.grpNuevoIngreso.Text = "Ingresar Nuevo Alumno";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(168, 46);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(35, 20);
            this.txtAño.TabIndex = 31;
            this.txtAño.Text = "Año";
            this.txtAño.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAño_MouseClick);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(127, 46);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(35, 20);
            this.txtMes.TabIndex = 30;
            this.txtMes.Text = "Mes";
            this.txtMes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMes_MouseClick);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(86, 46);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(35, 20);
            this.txtDia.TabIndex = 29;
            this.txtDia.Text = "Día";
            this.txtDia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDia_MouseClick);
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.Location = new System.Drawing.Point(80, 98);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(117, 21);
            this.btnNuevoIngreso.TabIndex = 12;
            this.btnNuevoIngreso.Text = "Ingresar Alumno";
            this.btnNuevoIngreso.UseVisualStyleBackColor = true;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // txtRUT
            // 
            this.txtRUT.Location = new System.Drawing.Point(117, 72);
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(87, 20);
            this.txtRUT.TabIndex = 10;
            this.txtRUT.Text = "11.111.111-1";
            this.txtRUT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtRUT_MouseClick);
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.Location = new System.Drawing.Point(5, 49);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(78, 13);
            this.lblNac.TabIndex = 14;
            this.lblNac.Text = "Fecha de Nac.";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRUT
            // 
            this.lblRUT.AutoSize = true;
            this.lblRUT.Location = new System.Drawing.Point(5, 75);
            this.lblRUT.Name = "lblRUT";
            this.lblRUT.Size = new System.Drawing.Size(30, 13);
            this.lblRUT.TabIndex = 11;
            this.lblRUT.Text = "RUT";
            // 
            // grpNotas
            // 
            this.grpNotas.Controls.Add(this.txtRUT_notas);
            this.grpNotas.Controls.Add(this.txtNota3);
            this.grpNotas.Controls.Add(this.lblRUT_notas);
            this.grpNotas.Controls.Add(this.lblNota3);
            this.grpNotas.Controls.Add(this.txtNota2);
            this.grpNotas.Controls.Add(this.lblNota2);
            this.grpNotas.Controls.Add(this.txtNota1);
            this.grpNotas.Controls.Add(this.btnNotas);
            this.grpNotas.Controls.Add(this.lblNota1);
            this.grpNotas.Location = new System.Drawing.Point(733, 170);
            this.grpNotas.Name = "grpNotas";
            this.grpNotas.Size = new System.Drawing.Size(210, 152);
            this.grpNotas.TabIndex = 12;
            this.grpNotas.TabStop = false;
            this.grpNotas.Text = "Ingreso de notas";
            // 
            // txtRUT_notas
            // 
            this.txtRUT_notas.Location = new System.Drawing.Point(124, 18);
            this.txtRUT_notas.Name = "txtRUT_notas";
            this.txtRUT_notas.ReadOnly = true;
            this.txtRUT_notas.Size = new System.Drawing.Size(80, 20);
            this.txtRUT_notas.TabIndex = 27;
            this.txtRUT_notas.Text = "11.111.111-1";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(168, 96);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(36, 20);
            this.txtNota3.TabIndex = 5;
            // 
            // lblRUT_notas
            // 
            this.lblRUT_notas.AutoSize = true;
            this.lblRUT_notas.Location = new System.Drawing.Point(5, 21);
            this.lblRUT_notas.Name = "lblRUT_notas";
            this.lblRUT_notas.Size = new System.Drawing.Size(30, 13);
            this.lblRUT_notas.TabIndex = 28;
            this.lblRUT_notas.Text = "RUT";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(5, 99);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 20;
            this.lblNota3.Text = "Nota 3";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(168, 70);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(36, 20);
            this.txtNota2.TabIndex = 4;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(5, 73);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 18;
            this.lblNota2.Text = "Nota 2";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(168, 44);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(36, 20);
            this.txtNota1.TabIndex = 3;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(80, 122);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(117, 21);
            this.btnNotas.TabIndex = 6;
            this.btnNotas.Text = "Ingresar Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(5, 47);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 16;
            this.lblNota1.Text = "Nota 1";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetalles.Location = new System.Drawing.Point(342, 38);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalles.Size = new System.Drawing.Size(369, 381);
            this.txtDetalles.TabIndex = 2;
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 22);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(78, 13);
            this.lblAlumnos.TabIndex = 16;
            this.lblAlumnos.Text = "Lista de Clases";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(339, 22);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(100, 13);
            this.lblDetalles.TabIndex = 17;
            this.lblDetalles.Text = "Detalles del Alumno";
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.txtNombre_quitarAlumno);
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.txtRUT_eliminar);
            this.grpEliminar.Controls.Add(this.lblNombre_eliminar);
            this.grpEliminar.Controls.Add(this.lblRUT_eliminar);
            this.grpEliminar.Enabled = false;
            this.grpEliminar.Location = new System.Drawing.Point(733, 582);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(210, 99);
            this.grpEliminar.TabIndex = 15;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Quitar Alumno";
            // 
            // txtNombre_quitarAlumno
            // 
            this.txtNombre_quitarAlumno.Location = new System.Drawing.Point(55, 19);
            this.txtNombre_quitarAlumno.Name = "txtNombre_quitarAlumno";
            this.txtNombre_quitarAlumno.Size = new System.Drawing.Size(143, 20);
            this.txtNombre_quitarAlumno.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(81, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 21);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtRUT_eliminar
            // 
            this.txtRUT_eliminar.Location = new System.Drawing.Point(117, 45);
            this.txtRUT_eliminar.Name = "txtRUT_eliminar";
            this.txtRUT_eliminar.ReadOnly = true;
            this.txtRUT_eliminar.Size = new System.Drawing.Size(80, 20);
            this.txtRUT_eliminar.TabIndex = 10;
            this.txtRUT_eliminar.Text = "11.111.111-1";
            // 
            // lblNombre_eliminar
            // 
            this.lblNombre_eliminar.AutoSize = true;
            this.lblNombre_eliminar.Location = new System.Drawing.Point(5, 22);
            this.lblNombre_eliminar.Name = "lblNombre_eliminar";
            this.lblNombre_eliminar.Size = new System.Drawing.Size(44, 13);
            this.lblNombre_eliminar.TabIndex = 10;
            this.lblNombre_eliminar.Text = "Nombre";
            // 
            // lblRUT_eliminar
            // 
            this.lblRUT_eliminar.AutoSize = true;
            this.lblRUT_eliminar.Location = new System.Drawing.Point(9, 48);
            this.lblRUT_eliminar.Name = "lblRUT_eliminar";
            this.lblRUT_eliminar.Size = new System.Drawing.Size(30, 13);
            this.lblRUT_eliminar.TabIndex = 11;
            this.lblRUT_eliminar.Text = "RUT";
            // 
            // grpObservacion
            // 
            this.grpObservacion.Controls.Add(this.btnEliminar_observacion);
            this.grpObservacion.Controls.Add(this.txtRUT_quitarObservacion);
            this.grpObservacion.Controls.Add(this.lblRUT_quitarObservacion);
            this.grpObservacion.Enabled = false;
            this.grpObservacion.Location = new System.Drawing.Point(733, 478);
            this.grpObservacion.Name = "grpObservacion";
            this.grpObservacion.Size = new System.Drawing.Size(210, 99);
            this.grpObservacion.TabIndex = 16;
            this.grpObservacion.TabStop = false;
            this.grpObservacion.Text = "Quitar Observaciones";
            // 
            // btnEliminar_observacion
            // 
            this.btnEliminar_observacion.Location = new System.Drawing.Point(80, 72);
            this.btnEliminar_observacion.Name = "btnEliminar_observacion";
            this.btnEliminar_observacion.Size = new System.Drawing.Size(117, 21);
            this.btnEliminar_observacion.TabIndex = 12;
            this.btnEliminar_observacion.Text = "Eliminar";
            this.btnEliminar_observacion.UseVisualStyleBackColor = true;
            this.btnEliminar_observacion.Click += new System.EventHandler(this.btnEliminar_observacion_Click);
            // 
            // txtRUT_quitarObservacion
            // 
            this.txtRUT_quitarObservacion.Location = new System.Drawing.Point(117, 19);
            this.txtRUT_quitarObservacion.Name = "txtRUT_quitarObservacion";
            this.txtRUT_quitarObservacion.ReadOnly = true;
            this.txtRUT_quitarObservacion.Size = new System.Drawing.Size(80, 20);
            this.txtRUT_quitarObservacion.TabIndex = 10;
            this.txtRUT_quitarObservacion.Text = "11.111.111-1";
            // 
            // lblRUT_quitarObservacion
            // 
            this.lblRUT_quitarObservacion.AutoSize = true;
            this.lblRUT_quitarObservacion.Location = new System.Drawing.Point(5, 22);
            this.lblRUT_quitarObservacion.Name = "lblRUT_quitarObservacion";
            this.lblRUT_quitarObservacion.Size = new System.Drawing.Size(30, 13);
            this.lblRUT_quitarObservacion.TabIndex = 11;
            this.lblRUT_quitarObservacion.Text = "RUT";
            // 
            // grpReemplazar_nota
            // 
            this.grpReemplazar_nota.Controls.Add(this.txtNota3_reemplazo);
            this.grpReemplazar_nota.Controls.Add(this.btnReemplazar_nota);
            this.grpReemplazar_nota.Controls.Add(this.lblnota3_reemplazar);
            this.grpReemplazar_nota.Controls.Add(this.txtRUT_reemplazarNotas);
            this.grpReemplazar_nota.Controls.Add(this.txtNota2_reemplazo);
            this.grpReemplazar_nota.Controls.Add(this.lblRUT_reemplazarNotas);
            this.grpReemplazar_nota.Controls.Add(this.lblnota2_reemplazar);
            this.grpReemplazar_nota.Controls.Add(this.lblnota1_reemplazar);
            this.grpReemplazar_nota.Controls.Add(this.txtNota1_reemplazo);
            this.grpReemplazar_nota.Enabled = false;
            this.grpReemplazar_nota.Location = new System.Drawing.Point(733, 328);
            this.grpReemplazar_nota.Name = "grpReemplazar_nota";
            this.grpReemplazar_nota.Size = new System.Drawing.Size(210, 144);
            this.grpReemplazar_nota.TabIndex = 17;
            this.grpReemplazar_nota.TabStop = false;
            this.grpReemplazar_nota.Text = "Reemplazar Notas";
            // 
            // txtNota3_reemplazo
            // 
            this.txtNota3_reemplazo.Location = new System.Drawing.Point(168, 94);
            this.txtNota3_reemplazo.Name = "txtNota3_reemplazo";
            this.txtNota3_reemplazo.Size = new System.Drawing.Size(36, 20);
            this.txtNota3_reemplazo.TabIndex = 23;
            // 
            // btnReemplazar_nota
            // 
            this.btnReemplazar_nota.Location = new System.Drawing.Point(80, 117);
            this.btnReemplazar_nota.Name = "btnReemplazar_nota";
            this.btnReemplazar_nota.Size = new System.Drawing.Size(117, 21);
            this.btnReemplazar_nota.TabIndex = 12;
            this.btnReemplazar_nota.Text = "Reemplazar";
            this.btnReemplazar_nota.UseVisualStyleBackColor = true;
            this.btnReemplazar_nota.Click += new System.EventHandler(this.btnReemplazar_nota_Click);
            // 
            // lblnota3_reemplazar
            // 
            this.lblnota3_reemplazar.AutoSize = true;
            this.lblnota3_reemplazar.Location = new System.Drawing.Point(5, 97);
            this.lblnota3_reemplazar.Name = "lblnota3_reemplazar";
            this.lblnota3_reemplazar.Size = new System.Drawing.Size(39, 13);
            this.lblnota3_reemplazar.TabIndex = 26;
            this.lblnota3_reemplazar.Text = "Nota 3";
            // 
            // txtRUT_reemplazarNotas
            // 
            this.txtRUT_reemplazarNotas.Location = new System.Drawing.Point(124, 15);
            this.txtRUT_reemplazarNotas.Name = "txtRUT_reemplazarNotas";
            this.txtRUT_reemplazarNotas.ReadOnly = true;
            this.txtRUT_reemplazarNotas.Size = new System.Drawing.Size(80, 20);
            this.txtRUT_reemplazarNotas.TabIndex = 10;
            this.txtRUT_reemplazarNotas.Text = "11.111.111-1";
            // 
            // txtNota2_reemplazo
            // 
            this.txtNota2_reemplazo.Location = new System.Drawing.Point(168, 68);
            this.txtNota2_reemplazo.Name = "txtNota2_reemplazo";
            this.txtNota2_reemplazo.Size = new System.Drawing.Size(36, 20);
            this.txtNota2_reemplazo.TabIndex = 22;
            // 
            // lblRUT_reemplazarNotas
            // 
            this.lblRUT_reemplazarNotas.AutoSize = true;
            this.lblRUT_reemplazarNotas.Location = new System.Drawing.Point(5, 18);
            this.lblRUT_reemplazarNotas.Name = "lblRUT_reemplazarNotas";
            this.lblRUT_reemplazarNotas.Size = new System.Drawing.Size(30, 13);
            this.lblRUT_reemplazarNotas.TabIndex = 11;
            this.lblRUT_reemplazarNotas.Text = "RUT";
            // 
            // lblnota2_reemplazar
            // 
            this.lblnota2_reemplazar.AutoSize = true;
            this.lblnota2_reemplazar.Location = new System.Drawing.Point(5, 71);
            this.lblnota2_reemplazar.Name = "lblnota2_reemplazar";
            this.lblnota2_reemplazar.Size = new System.Drawing.Size(39, 13);
            this.lblnota2_reemplazar.TabIndex = 25;
            this.lblnota2_reemplazar.Text = "Nota 2";
            // 
            // lblnota1_reemplazar
            // 
            this.lblnota1_reemplazar.AutoSize = true;
            this.lblnota1_reemplazar.Location = new System.Drawing.Point(5, 45);
            this.lblnota1_reemplazar.Name = "lblnota1_reemplazar";
            this.lblnota1_reemplazar.Size = new System.Drawing.Size(39, 13);
            this.lblnota1_reemplazar.TabIndex = 24;
            this.lblnota1_reemplazar.Text = "Nota 1";
            // 
            // txtNota1_reemplazo
            // 
            this.txtNota1_reemplazo.Location = new System.Drawing.Point(168, 42);
            this.txtNota1_reemplazo.Name = "txtNota1_reemplazo";
            this.txtNota1_reemplazo.Size = new System.Drawing.Size(36, 20);
            this.txtNota1_reemplazo.TabIndex = 21;
            // 
            // chkReemplazar_notas
            // 
            this.chkReemplazar_notas.AutoSize = true;
            this.chkReemplazar_notas.Location = new System.Drawing.Point(717, 328);
            this.chkReemplazar_notas.Name = "chkReemplazar_notas";
            this.chkReemplazar_notas.Size = new System.Drawing.Size(15, 14);
            this.chkReemplazar_notas.TabIndex = 27;
            this.chkReemplazar_notas.UseVisualStyleBackColor = true;
            this.chkReemplazar_notas.CheckedChanged += new System.EventHandler(this.chkReemplazar_notas_CheckedChanged);
            // 
            // chkQuitar_observacion
            // 
            this.chkQuitar_observacion.AutoSize = true;
            this.chkQuitar_observacion.Location = new System.Drawing.Point(717, 479);
            this.chkQuitar_observacion.Name = "chkQuitar_observacion";
            this.chkQuitar_observacion.Size = new System.Drawing.Size(15, 14);
            this.chkQuitar_observacion.TabIndex = 28;
            this.chkQuitar_observacion.UseVisualStyleBackColor = true;
            this.chkQuitar_observacion.CheckedChanged += new System.EventHandler(this.chkQuitar_observacion_CheckedChanged);
            // 
            // chkQuitar_alumno
            // 
            this.chkQuitar_alumno.AutoSize = true;
            this.chkQuitar_alumno.Location = new System.Drawing.Point(717, 583);
            this.chkQuitar_alumno.Name = "chkQuitar_alumno";
            this.chkQuitar_alumno.Size = new System.Drawing.Size(15, 14);
            this.chkQuitar_alumno.TabIndex = 29;
            this.chkQuitar_alumno.UseVisualStyleBackColor = true;
            this.chkQuitar_alumno.CheckedChanged += new System.EventHandler(this.chkQuitar_alumno_CheckedChanged);
            // 
            // dgvListadeClases
            // 
            this.dgvListadeClases.AllowUserToAddRows = false;
            this.dgvListadeClases.AllowUserToDeleteRows = false;
            this.dgvListadeClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadeClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumnos,
            this.rutAlumno});
            this.dgvListadeClases.Location = new System.Drawing.Point(15, 40);
            this.dgvListadeClases.MultiSelect = false;
            this.dgvListadeClases.Name = "dgvListadeClases";
            this.dgvListadeClases.ReadOnly = true;
            this.dgvListadeClases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadeClases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListadeClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadeClases.Size = new System.Drawing.Size(321, 641);
            this.dgvListadeClases.TabIndex = 30;
            this.dgvListadeClases.SelectionChanged += new System.EventHandler(this.dgvListadeClases_SelectionChanged);
            // 
            // NombreAlumnos
            // 
            this.NombreAlumnos.HeaderText = "Nombre";
            this.NombreAlumnos.Name = "NombreAlumnos";
            this.NombreAlumnos.ReadOnly = true;
            this.NombreAlumnos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreAlumnos.Width = 170;
            // 
            // rutAlumno
            // 
            this.rutAlumno.HeaderText = "RUT";
            this.rutAlumno.MaxInputLength = 12;
            this.rutAlumno.Name = "rutAlumno";
            this.rutAlumno.ReadOnly = true;
            this.rutAlumno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rutAlumno.Width = 107;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(6, 73);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(353, 149);
            this.txtObservacion.TabIndex = 7;
            this.txtObservacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtObservacion_MouseClick);
            // 
            // btnObservacion
            // 
            this.btnObservacion.Location = new System.Drawing.Point(242, 229);
            this.btnObservacion.Name = "btnObservacion";
            this.btnObservacion.Size = new System.Drawing.Size(117, 21);
            this.btnObservacion.TabIndex = 8;
            this.btnObservacion.Text = "Ingresar Observación";
            this.btnObservacion.UseVisualStyleBackColor = true;
            this.btnObservacion.Click += new System.EventHandler(this.btnObservacion_Click);
            // 
            // txtTitulo_observacion
            // 
            this.txtTitulo_observacion.Location = new System.Drawing.Point(56, 22);
            this.txtTitulo_observacion.Name = "txtTitulo_observacion";
            this.txtTitulo_observacion.Size = new System.Drawing.Size(189, 20);
            this.txtTitulo_observacion.TabIndex = 21;
            // 
            // lblTitulo_observacion
            // 
            this.lblTitulo_observacion.AutoSize = true;
            this.lblTitulo_observacion.Location = new System.Drawing.Point(6, 25);
            this.lblTitulo_observacion.Name = "lblTitulo_observacion";
            this.lblTitulo_observacion.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo_observacion.TabIndex = 21;
            this.lblTitulo_observacion.Text = "Titulo";
            // 
            // txtDia_Obs
            // 
            this.txtDia_Obs.Location = new System.Drawing.Point(56, 48);
            this.txtDia_Obs.Name = "txtDia_Obs";
            this.txtDia_Obs.Size = new System.Drawing.Size(35, 20);
            this.txtDia_Obs.TabIndex = 32;
            this.txtDia_Obs.Text = "Día";
            this.txtDia_Obs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDia_Obs_MouseClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 51);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha";
            // 
            // txtMes_Obs
            // 
            this.txtMes_Obs.Location = new System.Drawing.Point(97, 48);
            this.txtMes_Obs.Name = "txtMes_Obs";
            this.txtMes_Obs.Size = new System.Drawing.Size(35, 20);
            this.txtMes_Obs.TabIndex = 33;
            this.txtMes_Obs.Text = "Mes";
            this.txtMes_Obs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMes_Obs_MouseClick);
            // 
            // txtAño_obs
            // 
            this.txtAño_obs.Location = new System.Drawing.Point(138, 48);
            this.txtAño_obs.Name = "txtAño_obs";
            this.txtAño_obs.Size = new System.Drawing.Size(35, 20);
            this.txtAño_obs.TabIndex = 34;
            this.txtAño_obs.Text = "Año";
            // 
            // grpObservaciones
            // 
            this.grpObservaciones.Controls.Add(this.txtAño_obs);
            this.grpObservaciones.Controls.Add(this.txtMes_Obs);
            this.grpObservaciones.Controls.Add(this.lblFecha);
            this.grpObservaciones.Controls.Add(this.txtDia_Obs);
            this.grpObservaciones.Controls.Add(this.lblTitulo_observacion);
            this.grpObservaciones.Controls.Add(this.txtTitulo_observacion);
            this.grpObservaciones.Controls.Add(this.btnObservacion);
            this.grpObservaciones.Controls.Add(this.txtObservacion);
            this.grpObservaciones.Location = new System.Drawing.Point(342, 425);
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Size = new System.Drawing.Size(369, 256);
            this.grpObservaciones.TabIndex = 13;
            this.grpObservaciones.TabStop = false;
            this.grpObservaciones.Text = "Ingreso de observaciones";
            // 
            // frmLibrodeClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 690);
            this.Controls.Add(this.dgvListadeClases);
            this.Controls.Add(this.chkReemplazar_notas);
            this.Controls.Add(this.chkQuitar_observacion);
            this.Controls.Add(this.chkQuitar_alumno);
            this.Controls.Add(this.grpReemplazar_nota);
            this.Controls.Add(this.grpObservacion);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.grpObservaciones);
            this.Controls.Add(this.grpNuevoIngreso);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.grpNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLibrodeClases";
            this.Text = "Libro de Clases";
            this.grpNuevoIngreso.ResumeLayout(false);
            this.grpNuevoIngreso.PerformLayout();
            this.grpNotas.ResumeLayout(false);
            this.grpNotas.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.grpObservacion.ResumeLayout(false);
            this.grpObservacion.PerformLayout();
            this.grpReemplazar_nota.ResumeLayout(false);
            this.grpReemplazar_nota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadeClases)).EndInit();
            this.grpObservaciones.ResumeLayout(false);
            this.grpObservaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNuevoIngreso;
        private System.Windows.Forms.Button btnNuevoIngreso;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.Label lblRUT;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.GroupBox grpNotas;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtRUT_eliminar;
        private System.Windows.Forms.Label lblNombre_eliminar;
        private System.Windows.Forms.Label lblRUT_eliminar;
        private System.Windows.Forms.TextBox txtNombre_quitarAlumno;
        private System.Windows.Forms.GroupBox grpObservacion;
        private System.Windows.Forms.Button btnEliminar_observacion;
        private System.Windows.Forms.TextBox txtRUT_quitarObservacion;
        private System.Windows.Forms.Label lblRUT_quitarObservacion;
        private System.Windows.Forms.GroupBox grpReemplazar_nota;
        private System.Windows.Forms.TextBox txtNota3_reemplazo;
        private System.Windows.Forms.Button btnReemplazar_nota;
        private System.Windows.Forms.Label lblnota3_reemplazar;
        private System.Windows.Forms.TextBox txtRUT_reemplazarNotas;
        private System.Windows.Forms.TextBox txtNota2_reemplazo;
        private System.Windows.Forms.Label lblRUT_reemplazarNotas;
        private System.Windows.Forms.Label lblnota2_reemplazar;
        private System.Windows.Forms.Label lblnota1_reemplazar;
        private System.Windows.Forms.TextBox txtNota1_reemplazo;
        private System.Windows.Forms.TextBox txtRUT_notas;
        private System.Windows.Forms.Label lblRUT_notas;
        private System.Windows.Forms.CheckBox chkQuitar_alumno;
        private System.Windows.Forms.CheckBox chkQuitar_observacion;
        private System.Windows.Forms.CheckBox chkReemplazar_notas;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.DataGridView dgvListadeClases;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnObservacion;
        private System.Windows.Forms.TextBox txtTitulo_observacion;
        private System.Windows.Forms.Label lblTitulo_observacion;
        private System.Windows.Forms.TextBox txtDia_Obs;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMes_Obs;
        private System.Windows.Forms.TextBox txtAño_obs;
        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutAlumno;
    }
}

