using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{      
    // Herança
    public class Elevador : OutraClasse
    {
        private int andarAtual;
        private int totalAndares;
        private bool estadoPorta;
        
        
        private string nome;
        //GET E SET a classe
        public string Nome {
            get { return nome; }
            // VALUE é uma palavra reservada
            set { nome = value; }
        }

        private void Subir(int andarDesejado)
        {
            while (andarAtual < andarDesejado) 
            {
                andarAtual++;
            }
        }
        private void Descer(int andarDesejado)
        {
            while (andarAtual < andarDesejado)
            {
                andarAtual--;
            }
            //AbrirPorta();
        }
        private void AbrirPorta()
        {
            estadoPorta = true;
        }
        private void FecharPorta()
        {
            estadoPorta = false;
        }
        public void irParaAndar(int andarDesejado)
        {
            if (andarDesejado > andarAtual && andarDesejado < totalAndares)
            {
                Subir(andarDesejado);
            }
            else
            {
                Descer(andarDesejado);
            }
            
        }
    }
}
