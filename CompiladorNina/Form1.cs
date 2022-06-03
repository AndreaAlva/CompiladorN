using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CompiladorNina
{
    public partial class Form1 : Form
    {
        private List<token> lexemas;
        public Form1()
        {
            InitializeComponent();
            lexemas = new List<token>();
        }

        public void analizar(string texto)
        {
            token lexema;
            string[] fila = texto.Split("\r\n");
            int index = 0;
            foreach (string columns in fila)
            {
                int num = 0;
                string[] columnas = columns.Split(" ");
                foreach(string cadena in columnas)
                {
                    lexema = new token();
                    switch (cadena)
                    {
                        case "{":
                            lexema.Tipo = "PR";
                            break;
                        case "}":
                            lexema.Tipo = "PU";
                            break;
                        case "if":
                            lexema.Tipo = "CO";
                            break;
                        case "=":
                            lexema.Tipo = "PR";
                            break;
                        case "==":
                            lexema.Tipo = "OP";
                            break;
                        case "while":
                            lexema.Tipo = "PR";
                            break;
                        case "func":
                            lexema.Tipo = "PR";
                            break;
                        case "(":
                            lexema.Tipo = "PU";
                            break;
                        case ")":
                            lexema.Tipo = "PU";
                            break;
                    }
                    lexema.Columna = num;
                    lexema.Fila = index;
                    lexema.Valor = cadena;
                    lexemas.Add(lexema);
                    
                    num++;
                }
                string json = JsonConvert.SerializeObject(lexemas);
                System.IO.File.WriteAllText("..\\..\\..\\tokens.json", json);
                index++;
            }
        }

        private void analizarbtn_Click(object sender, EventArgs e)
        {
            analizar(codigofuente.Text.ToString());
        }
    }
}
