using System;
using System.Collections.Generic;

class Libro
{
	private string titulo;
	private string autor;
	private int anyo;
	private bool disponible;

	public Libro(string titulo, string autor, int anyo)
	{
		this.titulo = titulo;
		this.autor = autor;
		this.anyo = anyo;
		this.disponible = true;
	}

	public override string ToString()
	{
		return $"{titulo} - {autor} - {anyo}";
	}

	public string getTitulo()
	{
		return this.titulo;
	}

	public string getAutor()
	{
		return this.autor;
	}

	public int getAnyo()
	{
		return this.anyo;
	}

	public bool isDisponible()
	{
		return this.disponible;
	}

	public static void Main(string[] args)
	{
		List<Libro> libros = new List<Libro>();

		libros.Add(new Libro("El Quijote", "Miguel de Cervantes", 1605));
		libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", 1967));
		libros.Add(new Libro("Don Juan Tenorio", "José Zorrilla", 1844));

		for (int i = 0; i < libros.Count; i++)
		{
			Console.WriteLine(libros[i].ToString());
			if (libros[i].getAutor().Contains("Orwell"))
			{
				Console.WriteLine(libros[i].ToString());
			}
		}

		Console.WriteLine(DateTime.Now);
		Console.WriteLine(DateTime.Now.ToShortDateString());
	}
}
