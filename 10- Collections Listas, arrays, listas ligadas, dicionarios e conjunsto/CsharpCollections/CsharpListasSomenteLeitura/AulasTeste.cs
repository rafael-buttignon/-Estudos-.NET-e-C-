using System;

namespace CsharpListasSomenteLeitura
{
    public class Aulas : IComparable
        {
            private string titulo;
            private int tempo;

            public Aulas(string titulo, int tempo)
            {
                this.titulo = titulo;
                this.tempo = tempo;
            }

            public string Titulo { get => titulo; set => titulo = value; }
            public int Tempo { get => tempo; set => tempo = value; }

            public int CompareTo(object obj)
            {
                Aulas that = obj as Aulas;
                return this.titulo.CompareTo(that.titulo);
            }

            public override string ToString()
            {
                return $"[Titulo: {titulo}, tempo: {tempo} minutos]";
            }
        }
    }
