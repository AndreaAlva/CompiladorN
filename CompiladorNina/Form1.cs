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
            string[] filas = texto.Split("\n");
            int fila = 0;
            foreach (string columns in filas)
            {
                int column = 1;
                string[] columnas = columns.Split(" ");
                foreach(string cadena in columnas)
                {
                    lexema = new token();
                    switch (cadena)
                    {
                        case "{":
                            lexema.Tipo = "SG";
                            break;
                        case "}":
                            lexema.Tipo = "SG";
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
                            lexema.Tipo = "SG";
                            break;
                        case ")":
                            lexema.Tipo = "SG";
                            break;
                        case "!=":
                            lexema.Tipo = "OP";
                            break;
                        case "+":
                            lexema.Tipo = "OP";
                            break;
                        case "-":
                            lexema.Tipo = "OP";
                            break;
                        case "*":
                            lexema.Tipo = "OP";
                            break;
                        case "/":
                            lexema.Tipo = "OP";
                            break;
                        case ";":
                            lexema.Tipo = "SP";
                            break;
                        default:
                            if (int.TryParse(cadena, out int parsed) == true)
                            {
                                lexema.Tipo = "LN";
                            }
                            else
                            {
                                lexema.Tipo = "ID";
                            }
                            break;    
                    }
                    lexema.Columna = column;
                    lexema.Fila = fila;
                    lexema.Valor = cadena;
                    lexemas.Add(lexema);
                    
                    column++;
                }
                string json = JsonConvert.SerializeObject(lexemas);
                System.IO.File.WriteAllText("..\\..\\..\\tokens.json", json);
                fila++;
            }
        }

        private void analizarbtn_Click(object sender, EventArgs e)
        {
            analizar(codigofuente.Text.ToString());
        }
        //char last = 'a';
        private void codigofuente_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* char actual=' ';
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                if(char.IsLetterOrDigit(last))
                {
                    actual = e.KeyChar;
                    richTextBox1.AppendText("adfa");
                    MessageBox.Show("llego aca");
                    //e.KeyChar = actual;
                    richTextBox1.AppendText(e.KeyChar.ToString());
                }
            }
            last = actual;*/
        }
    }
}
