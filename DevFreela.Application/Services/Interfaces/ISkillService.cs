using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;

namespace DevFreela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
