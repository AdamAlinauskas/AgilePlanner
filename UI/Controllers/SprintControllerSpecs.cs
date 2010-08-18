using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Infrastructure.Testing;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.Interfaces;
using Task.BaseInterfaces;
using UI.Models;

namespace UI.Controllers
{
    
    public class SprintControllerSpecs
    {


        public abstract class behaves_like_a_sprintController : ContextSpec<SprintController>
        {
            protected IQuery<SprintDto> retrieveSprintsQuery;
            protected ISaveUpdateCommand<SprintDto> saveCommand;

            public override SprintController CreateSut()
            {
                retrieveSprintsQuery = MockRepository.GenerateMock<IQuery<SprintDto>>();
                saveCommand = MockRepository.GenerateMock<ISaveUpdateCommand<SprintDto>>();
                return new SprintController(retrieveSprintsQuery, saveCommand);
            }
        }



        public class when_displaying_the_listing_view : behaves_like_a_sprintController
        {

            public override void UnderTheseConditions()
            {
                sprints = Enumerable.Empty<SprintDto>();
                retrieveSprintsQuery.Stub(x => x.All()).Return(sprints);
            }

            public override void BecauseOf()
            {
                result = sut.Index();
            }

            [Test]
            public void it_should_have_displayed_the_correct_view()
            {
                result.ViewName.ShouldBeEqualTo(string.Empty);
            }

            [Test]
            public void it_should_have_the_correct_model()
            {
                result.ViewData.Model.ShouldBeEqualTo(sprints);
            } 

            private ViewResult result;
            private IEnumerable<SprintDto> sprints;
        }
    }
}