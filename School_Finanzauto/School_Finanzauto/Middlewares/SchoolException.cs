using System.Runtime.Serialization;

namespace School_Finanzauto.Middlewares
{
	public class SchoolException : Exception
	{
		public List<string> Errores { get; set; } = new List<string>();


		public SchoolException()
		{
		}

		public SchoolException(string message)
			: base(message)
		{
			Errores.Add(message);
		}

		public SchoolException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected SchoolException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
	}
}
