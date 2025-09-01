namespace BE
{
    public class USUARIO
    {
		private int _id_usuario;

		public int IDUsuario
		{
			get { return _id_usuario; }
			set { _id_usuario = value; }
		}
		private string _nombre_usuario;

		public string NombreUsuario
		{
			get { return _nombre_usuario; }
			set { _nombre_usuario = value; }
		}
		private string _contraseña;

		public string Contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}
		public USUARIO() { }
	}
}
