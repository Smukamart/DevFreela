using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevfreelaDbContext
    {
        public DevfreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descrição de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Luis Felipe", "luisdev@luisdev.com.br", new DateTime(1992, 1, 1)),
                new User("Robert C Martin", "robert@luisdev.com.br", new DateTime(1950, 1, 1)),
                new User("Anderson", "anderson@luisdev.com.br", new DateTime(1980, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skills> Skill { get; set; }
    }
}