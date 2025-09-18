using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]

        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            //arrange
            var projectRepositoryMoc = new Mock<IProjectRepository>();

            var createProjectCommand = new CreateProjectCommand
            {
                Title = "Test",
                Description = "Test haha",
                TotalCost = 5000,
                IdClient = 1,
                IdFreelancer = 1
            };

            var createProjectCommandHandler = new CreateProjectCommandHandler(projectRepositoryMoc.Object);

            //act

            var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());

            //assert

            Assert.True(id >= 0);

            projectRepositoryMoc.Verify(p => p.AddAsync(It.IsAny<Project>()), Times.Once);
        }

    }
}
