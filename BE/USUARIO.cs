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
		private string _salt;

		public string Salt
		{
			get { return _salt; }
			set { _salt = value; }
		}

		private List<COMPONENTE> _lista_permisos;

		public List<COMPONENTE> ListaPermisos
		{
			get { return _lista_permisos; }
			set { _lista_permisos = value; }
		}

		public USUARIO() { }
	}
}
