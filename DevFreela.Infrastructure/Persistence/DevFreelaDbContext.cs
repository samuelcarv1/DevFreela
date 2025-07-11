using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {

        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projecto ASPNET Core 1","Minha descricao de Projeto 1",1,1,10000),
                new Project("Meu projecto ASPNET Core 2","Minha descricao de Projeto 2",1,1,20000),
                new Project("Meu projecto ASPNET Core 3","Minha descricao de Projeto 3",1,1,30000)
            };

            Users = new List<User>
            {
                new User("Luis Felipe", "luiddev@luisdev.com.br", new DateTime(1995,1,1)),
                new User("Samuel Carvalho", "samuelcarvalho@luisdev.com.br", new DateTime(2000,4,29)),
                new User("Humberto Ramone", "Humberto Ramone@luisdev.com.br", new DateTime(1998,2,8))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };

        }
        public List<Project> Projects { get; private set; }
        public List<User> Users { get; private set; }

        public List<Skill> Skills { get; private set; }

        public List<ProjectComment> ProjectComments { get; private set; }

    }
}
