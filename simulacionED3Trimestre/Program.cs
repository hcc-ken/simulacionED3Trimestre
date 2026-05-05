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
}
