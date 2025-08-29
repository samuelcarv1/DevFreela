using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        ProjectDetailsViewModel GetById(int id);

        void Update(UpdateProjectInputModel inputModel);


        void Start(int id);
        void Finish(int id);
    }
}
