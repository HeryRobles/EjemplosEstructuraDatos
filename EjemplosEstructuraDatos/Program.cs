using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Ramón Heriberto";
alumno1.ApellidoPaterno = "Robles";
alumno1.ApellidoMaterno = "Coronado";
alumno1.Matricula = "C914";
alumno1.FechaNacimiento = new DateTime(1990,08,26);


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Adrian";
alumno2.ApellidoPaterno = "Robles";
alumno2.ApellidoMaterno = "Valenzuela";
alumno2.Matricula = "A316";
alumno2.FechaNacimiento = new DateTime(2000, 10, 03);

Alumno alumno3 = new Alumno();
alumno3.Nombres = "Ximena Elizabeth";
alumno3.ApellidoPaterno = "Robles";
alumno3.ApellidoMaterno = "Valenzuela";
alumno3.Matricula = "A163";
alumno3.FechaNacimiento = new DateTime(2000, 06, 16);


lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3);

foreach (Alumno alumnoEnLista in lista)
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto
        + " Matrícula: "
        + alumnoEnLista.Matricula
        + " Fecha de Nacimiento: "
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));

}
