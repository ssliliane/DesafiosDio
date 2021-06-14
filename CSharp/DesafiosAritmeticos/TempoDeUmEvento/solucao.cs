/******************************************************************************************************************************
                                                TEMPO DE UM EVENTO
*******************************************************************************************************************************
Desafio:
Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. 
O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.

Entrada
Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. 
Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. 
a terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.

Saída
Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.

******************************************************************************************************************************/

using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int diaInicio, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int diaTermino, horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            
            string[] dadosInicio = Console.ReadLine().Split(" ");
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio    = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio  = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
    
            string[] dadosTermino = Console.ReadLine().Split(" ");
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino     = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino   = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);
           
            int W =  (diaTermino - diaInicio);
            int X = (horaMomentoTermino - horaMomentoInicio);
            int Y = (minutoMomentoTermino - minutoMomentoInicio);
            int Z = (segundoMomentoTerminio - segundoMomentoInicio);
            
            if (Z < 0)
            {
              Z += 60;
              Y--;
            }
        
            if (Y < 0)
            {
              Y += 60;
              X--;
            }
        
            if (X < 0)
            {
              X += 24;
              W--;
            }
          

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);


    }

}