
// This file has been generated by the GUI designer. Do not modify.
namespace Hotel
{
	public partial class fmr_usuario
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label lbl_titulo;

		private global::Gtk.Label lbl_nombres;

		private global::Gtk.Label lbl_apellidos;

		private global::Gtk.Label lbl_email;

		private global::Gtk.Label lbl_usuario;

		private global::Gtk.Label lbl_pwd;

		private global::Gtk.Label lbl_pwd2;

		private global::Gtk.Entry txt_nombres;

		private global::Gtk.Entry txt_apellidos;

		private global::Gtk.Entry txt_email;

		private global::Gtk.Entry txt_user;

		private global::Gtk.Entry txt_contraseña;

		private global::Gtk.Entry txt_repContraseña;

		private global::Gtk.Button btnGuardar;

		private global::Gtk.Button btnCancelar;

		private global::Gtk.Button btnEliminar;

		private global::Gtk.Entry txtbuscar;

		private global::Gtk.Button btnBuscar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView twUsuario;

		private global::Gtk.Button btnActualizar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Hotel.fmr_usuario
			this.Name = "Hotel.fmr_usuario";
			this.Title = global::Mono.Unix.Catalog.GetString("fmr_usuario");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Hotel.fmr_usuario.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_titulo = new global::Gtk.Label();
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.LabelProp = global::Mono.Unix.Catalog.GetString("Gestión de Usuarios");
			this.fixed1.Add(this.lbl_titulo);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_titulo]));
			w1.X = 319;
			w1.Y = 16;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_nombres = new global::Gtk.Label();
			this.lbl_nombres.Name = "lbl_nombres";
			this.lbl_nombres.LabelProp = global::Mono.Unix.Catalog.GetString("Nombres:");
			this.fixed1.Add(this.lbl_nombres);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_nombres]));
			w2.X = 25;
			w2.Y = 75;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_apellidos = new global::Gtk.Label();
			this.lbl_apellidos.Name = "lbl_apellidos";
			this.lbl_apellidos.LabelProp = global::Mono.Unix.Catalog.GetString("Apellidos:");
			this.fixed1.Add(this.lbl_apellidos);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_apellidos]));
			w3.X = 22;
			w3.Y = 115;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_email = new global::Gtk.Label();
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.LabelProp = global::Mono.Unix.Catalog.GetString("Email:");
			this.fixed1.Add(this.lbl_email);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_email]));
			w4.X = 45;
			w4.Y = 163;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_usuario = new global::Gtk.Label();
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario:");
			this.fixed1.Add(this.lbl_usuario);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_usuario]));
			w5.X = 500;
			w5.Y = 75;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_pwd = new global::Gtk.Label();
			this.lbl_pwd.Name = "lbl_pwd";
			this.lbl_pwd.LabelProp = global::Mono.Unix.Catalog.GetString("Contraseña:");
			this.fixed1.Add(this.lbl_pwd);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_pwd]));
			w6.X = 473;
			w6.Y = 115;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.lbl_pwd2 = new global::Gtk.Label();
			this.lbl_pwd2.Name = "lbl_pwd2";
			this.lbl_pwd2.LabelProp = global::Mono.Unix.Catalog.GetString("Confirmar contraseña:");
			this.fixed1.Add(this.lbl_pwd2);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl_pwd2]));
			w7.X = 403;
			w7.Y = 163;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_nombres = new global::Gtk.Entry();
			this.txt_nombres.CanFocus = true;
			this.txt_nombres.Name = "txt_nombres";
			this.txt_nombres.IsEditable = true;
			this.txt_nombres.InvisibleChar = '•';
			this.fixed1.Add(this.txt_nombres);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_nombres]));
			w8.X = 103;
			w8.Y = 70;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_apellidos = new global::Gtk.Entry();
			this.txt_apellidos.CanFocus = true;
			this.txt_apellidos.Name = "txt_apellidos";
			this.txt_apellidos.IsEditable = true;
			this.txt_apellidos.InvisibleChar = '•';
			this.fixed1.Add(this.txt_apellidos);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_apellidos]));
			w9.X = 103;
			w9.Y = 113;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_email = new global::Gtk.Entry();
			this.txt_email.CanFocus = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.IsEditable = true;
			this.txt_email.InvisibleChar = '•';
			this.fixed1.Add(this.txt_email);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_email]));
			w10.X = 103;
			w10.Y = 158;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_user = new global::Gtk.Entry();
			this.txt_user.CanFocus = true;
			this.txt_user.Name = "txt_user";
			this.txt_user.IsEditable = true;
			this.txt_user.InvisibleChar = '•';
			this.fixed1.Add(this.txt_user);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_user]));
			w11.X = 560;
			w11.Y = 70;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_contraseña = new global::Gtk.Entry();
			this.txt_contraseña.CanFocus = true;
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.IsEditable = true;
			this.txt_contraseña.InvisibleChar = '•';
			this.fixed1.Add(this.txt_contraseña);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_contraseña]));
			w12.X = 560;
			w12.Y = 113;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txt_repContraseña = new global::Gtk.Entry();
			this.txt_repContraseña.CanFocus = true;
			this.txt_repContraseña.Name = "txt_repContraseña";
			this.txt_repContraseña.IsEditable = true;
			this.txt_repContraseña.InvisibleChar = '•';
			this.fixed1.Add(this.txt_repContraseña);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txt_repContraseña]));
			w13.X = 560;
			w13.Y = 158;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnGuardar = new global::Gtk.Button();
			this.btnGuardar.WidthRequest = 100;
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.fixed1.Add(this.btnGuardar);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnGuardar]));
			w14.X = 370;
			w14.Y = 205;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnCancelar = new global::Gtk.Button();
			this.btnCancelar.WidthRequest = 100;
			this.btnCancelar.CanFocus = true;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.UseUnderline = true;
			this.btnCancelar.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.fixed1.Add(this.btnCancelar);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCancelar]));
			w15.X = 475;
			w15.Y = 205;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnEliminar = new global::Gtk.Button();
			this.btnEliminar.WidthRequest = 100;
			this.btnEliminar.CanFocus = true;
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.UseUnderline = true;
			this.btnEliminar.Label = global::Mono.Unix.Catalog.GetString("Eliminar");
			this.fixed1.Add(this.btnEliminar);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnEliminar]));
			w16.X = 685;
			w16.Y = 205;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.txtbuscar = new global::Gtk.Entry();
			this.txtbuscar.WidthRequest = 520;
			this.txtbuscar.CanFocus = true;
			this.txtbuscar.Name = "txtbuscar";
			this.txtbuscar.IsEditable = true;
			this.txtbuscar.InvisibleChar = '•';
			this.fixed1.Add(this.txtbuscar);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.txtbuscar]));
			w17.X = 75;
			w17.Y = 250;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnBuscar = new global::Gtk.Button();
			this.btnBuscar.WidthRequest = 100;
			this.btnBuscar.CanFocus = true;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.UseUnderline = true;
			this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.fixed1.Add(this.btnBuscar);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnBuscar]));
			w18.X = 600;
			w18.Y = 246;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 540;
			this.GtkScrolledWindow.HeightRequest = 200;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.twUsuario = new global::Gtk.TreeView();
			this.twUsuario.CanFocus = true;
			this.twUsuario.Name = "twUsuario";
			this.GtkScrolledWindow.Add(this.twUsuario);
			this.fixed1.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
			w20.X = 73;
			w20.Y = 283;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnActualizar = new global::Gtk.Button();
			this.btnActualizar.WidthRequest = 100;
			this.btnActualizar.CanFocus = true;
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.UseUnderline = true;
			this.btnActualizar.Label = global::Mono.Unix.Catalog.GetString("Actualizar");
			this.fixed1.Add(this.btnActualizar);
			global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnActualizar]));
			w21.X = 580;
			w21.Y = 205;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 799;
			this.DefaultHeight = 495;
			this.Show();
			this.txt_nombres.Changed += new global::System.EventHandler(this.OnTxtNombresChanged);
			this.txt_apellidos.Changed += new global::System.EventHandler(this.OnTxtApellidosChanged);
			this.btnGuardar.Clicked += new global::System.EventHandler(this.OnBtnGuardarClicked);
			this.btnCancelar.Clicked += new global::System.EventHandler(this.OnBtnCancelarClicked);
			this.btnEliminar.Clicked += new global::System.EventHandler(this.OnBtnEliminarClicked);
			this.btnBuscar.Clicked += new global::System.EventHandler(this.OnBtnBuscarClicked);
			this.twUsuario.CursorChanged += new global::System.EventHandler(this.OnTwUsuarioCursorChanged);
			this.btnActualizar.Clicked += new global::System.EventHandler(this.OnBtnActualizarClicked);
		}
	}
}
