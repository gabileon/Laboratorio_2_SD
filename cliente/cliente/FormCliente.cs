using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using cliente.servicioChat;
using System.Net;



namespace cliente
{
    public partial class FormCliente : Form
    {
        // Atributos de los TextBox que se utilizan para iniciar sesión
        private TextBox nickName;
        private TextBox password;
        //private Button botonRegistrar;
        private Button botonConectar;
        // Hebra para escuchar mensajes
        public Thread receiver;
        delegate void SetTextCallback();

        // Constructor que inicializa la vista
        public FormCliente()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando el usuario quiere ingresar en la aplicación
        private void conectarBoton_Click(object sender, EventArgs e)
        {
            // Se obtiene la información del usuario ingresada
            String user = this.nickName.Text;
            String pass = password.Text;
            // Atributos para obtener la ip local del usuario
            String ipLocal = "";
            int valorLogin = 0;
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            // Se crea el objeto para acceder a los métodos del WS
            Comunicacion servicio = new Comunicacion();

            // Se realiza un búsqueda de la ip local que está conectado el cliente
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipLocal = ip.ToString();
                }
            }

            // Se verifica que se haya ingresado un usuario y una contraseña
            if ((user.CompareTo("") != 0) || (pass.CompareTo("") != 0))
            {
                try
                {
                    botonRegistrar.Enabled = false;
                    this.botonRegistrar.Enabled = false;
                    valorLogin = servicio.login(user, pass, ipLocal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    valorLogin = -1;
                }

                // El usuario ha ingresado el nombre y contraseña correctamente
                if (valorLogin == 1)
                {
                    // Habilitamos y deshabilitamos lo que corresponda
                    this.chat.Enabled = true;
                    this.botonConectar.Enabled = false;
                    this.desconectarBoton.Enabled = true;
                    this.nombre.Text = "¡Hola "+ user +"!";
                    this.mensaje.Enabled = true;
                    this.participantes.Enabled = true;
                    this.enviarBoton.Enabled = true;
                    this.ayudanteSalaBoton.Enabled = true;
                    // Comienza a actuar la hebra
                    receiver = new Thread(packetReceive);
                    receiver.IsBackground = true;
                    receiver.Start();
                }
                else if (valorLogin == 0)
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                else if (valorLogin == 2)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else if (valorLogin == 3)
                {
                    MessageBox.Show("Usuario ya conectado");
                }
                if (valorLogin == -1)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos de usuario y/o contraseña");
            }
        }

        public void packetReceive()
        {
            // Método que hace uso de métodos propios de la Clase Thread. Sleep puede recibir como parámetro
            // un entero que representa el tiempo que la Hebra quedará suspendida en milisegundos, en este
            // caso, se suspende la Hebra por dos segundos. Cada dos segundos se verifica si el Form asociado
            // a la variable "pantalla" ("Principal", como es definido en la línea 32) tiene el control o no, 
            // donde de tenerlo se hace una llamada al método Setboton().
            while (true)
            {
                Thread.Sleep(2000);
                if (chat.IsDisposed)
                {
                    this.Setboton();
                }
            }
        }

        private void Setboton()
        {
            // Método que se lleva a cabo cuando el Form "Principal" toma el control, esto es detectado por la
            // hebra y se lleva a cabo una función asíncrona que compara el ID de la hebra que hizo la llamada
            // (desde el método "clickBotonLogIn") con el ID de la hebra creada al presionar el botón que llama al
            // Form, los cuales de ser distintos generan un retorno de "true". Esto puede desarrollarse también 
            // con un parámetro como se observa en el método "SetTextpriv" del Form "Principal".
            if (this.botonConectar.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Setboton);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.botonConectar.Enabled = true;
                this.botonConectar.Enabled = true;
                this.nickName.Text = "";
                this.contrasena.Text = "";
                this.receiver.Abort();
            }
        }
    }
}
