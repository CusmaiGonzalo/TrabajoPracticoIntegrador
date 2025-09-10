namespace Servicios
{
    public class SessionManager
    {
        private static SessionManager _instance;
		public static SessionManager Instance
        {
            get
            {
                if (_instance == null) { throw new Exception("No hay sesión iniciada."); }
                return _instance;
            }
        }
        private BE.USUARIO _usuario_log;

		public BE.USUARIO UsuarioLog
		{
			get { return _usuario_log; }
			set { _usuario_log = value; }
		}
		private DateTime _fecha_ingreso;

		public DateTime FechaDeIngreso
		{
			get { return _fecha_ingreso; }
			set { _fecha_ingreso = value; }
		}
		private SessionManager() { }

		public static void LogIn(BE.USUARIO user)
		{
			if(_instance == null)
			{
                _instance = new SessionManager();
                Instance.UsuarioLog = user;
                Instance.FechaDeIngreso = DateTime.Now;
            }
			else
            {
                throw new Exception("Ya hay una sesión iniciada.");
            }
        }
        public static void LogOut()
        {
            if(_instance != null)
            {
                _instance.UsuarioLog = null;
                _instance.FechaDeIngreso = DateTime.MinValue;
                _instance = null;
            }
            else
            {
                throw new Exception("No hay sesión iniciada.");
            }
        }

    }
}
