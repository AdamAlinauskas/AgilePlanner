using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web.Mvc;
using Infrastructure.Testing;
using NUnit.Framework;
using Rhino.Mocks;
using Task.BaseInterfaces;
using UI.Models;
using ViewModel;
using Infrastructure.Extentions;

namespace UI.Controllers
{
    public class ProjectControllerSpecs
    {

        public abstract class behaves_like_a_ProjectController : ContextSpec<ProjectController>
        {
            protected IQuery<ProjectDto> query;

            public override ProjectController CreateSut()
            {
                query = MockRepository.GenerateMock<IQuery<ProjectDto>>();
                return new ProjectController(query);
            }
        }


        public class when_display_the_index_view : behaves_like_a_ProjectController
        {
            private ViewResult result;
            private IEnumerable<ProjectDto> queryData;

            public override void UnderTheseConditions()
            {
                queryData = Enumerable.Empty<ProjectDto>();
                query.Stub(x => x.All()).Return(queryData);
            }

            public override void BecauseOf()
            {
                result = sut.Index();
            }

            [Test]
            public void it_should_display_the_correct_view()
            {
                result.ViewName.ShouldBeEqualTo(String.Empty);
            }

            [Test]
            public void it_should_have_a_listing_of_projects_from_the_query()
            {
                result.ViewData.Model.DownCastTo<ProjectListingDto>().Projects.ShouldBeEqualTo(queryData);
            } 

        }

        public class when_displaying_the_create_view:behaves_like_a_ProjectController
        {
            private ViewResult result;

            public override void UnderTheseConditions(){}

            public override void BecauseOf()
            {
                result = sut.Create();
            }

            [Test]
            public void it_should_display_the_correct_view()
            {
                result.ViewName.ShouldBeEqualTo(string.Empty);
            } 
        }
    }
}