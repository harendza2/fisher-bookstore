using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {
        [Fact]
        public void ChangePublication()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "Mcgraw-Hill"
            };

             //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();

            Assert.Equal(expectedPublicationDate, actualPublicationDate);
        }
        [Fact]
        public void ChangePublisher()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "Mcgraw-Hill"
            };

             //Act
            var newPublisher = "Toms Books";
            book.ChangePublisher(newPublisher);

            //Assert
            var expectedPublisher = newPublisher.ToString();
            var actualPublisher = book.Publisher.ToString();

            Assert.Equal(expectedPublisher, actualPublisher);
        }
        [Fact]
        public void ChangeTitle()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "Mcgraw-Hill"
            };

             //Act
            var newTitle = "The Adventure of Tom Saywer";
            book.ChangeTitle(newTitle);

            //Assert
            var expectedTitle = newTitle.ToString();
            var actualTitle = book.Title.ToString();

            Assert.Equal(expectedTitle, actualTitle);
        }
                
    }
}
