using System;
namespace EMigrant.App.Dominio{
public class Migrante{
public int id { get; set; }
public string nombre { get; set; }
public string apellidos { get; set; }
public string tipo_documento { get; set; }
public string identificacion { get; set; }
public string pais_origen { get; set; }
public DateTime fecha_nacimiento {get;set;} 
public string email { get; set; }
public string telefono { get; set; }
public string direccion_actual { get; set; }
public string ciudad { get; set; }
public string situacion_laboral { get; set; }

 }
}

