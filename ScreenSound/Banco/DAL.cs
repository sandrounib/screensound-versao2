using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    //Classe generica abstrata, passa um valor atraves do tipo T(para colocar o tipo certo somente na hora que for usar), quem herda ela trerá que passa um tipo qualquer
    internal abstract class DAL<T> where T : class // quem herda a classe abstrata é obrigatorio implementar a assinatura dela. where T : class => É obrigatorio usar classe
    {
        private readonly ScreenSoundContext context;

        protected DAL(ScreenSoundContext context) //contrutor da classe dall
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            // return context.Musicas.ToList(); //banco-tabela-select
            return context.Set<T>().ToList(); //o set seria a tabela generica do banco

        }

    public void Adicionar(T objeto) //musica tipo generico
    {
        //o Set é uma tabela generica do tipo função
        context.Set<T>().Add(objeto); //banco-tabela-select
        context.SaveChanges();

    }
    public void Atualizar(T objeto)

    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }
    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

        public T? RecuperarPor(Func<T, bool> verificacao) //funçao generica que recebe uma classe no T e retorna um boleano, com parametro
        {
            //context= banco- Set=tabela - FirstOrDefault= sql 
            return context.Set<T>().FirstOrDefault(verificacao); //faz uma verificação no banco e atravez do bool retorna true ou false
        }
    }
}

  



  

