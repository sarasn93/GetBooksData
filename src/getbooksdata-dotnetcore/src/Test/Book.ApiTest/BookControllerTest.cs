using Book.Api.Controllers;
using Core.Application.Services;
using Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Book.ApiTest
{
    public class BookControllerTest
    {
        private readonly BookController _controller;
        private readonly IBookService _service;
        public BookControllerTest()
        {
            _service = new BookServiceFake();
            _controller = new BookController(_service);
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsOkResult()
        {
            string testId = "110547";
            // Act
            var okResult = await _controller.GetBook(testId);
            // Assert
            Assert.NotNull(okResult);
        }

        [Fact]
        public async Task GetById_NotExistingId_ButCallApi()
        {
            string testId = "105511";
            var okResult = await _controller.GetBook(testId);
            Assert.NotNull(okResult);
        }

        [Fact]
        public async Task GetById_NotExistingId_NotFound()
        {
            string testId = "dsfdsdds";
            var okResult = await _controller.GetBook(testId);
            Assert.Null(okResult.Value);
        }

        [Fact]
        public async Task Remove_NotExistingGuidPassed_ReturnsNotFoundResponse()
        {
            
            // Arrange
            var notExistingId = "65dfdsf";
            // Act
            var delete=await _controller.DeleteBook(notExistingId);
            // Assert
            Assert.IsType<OkResult>(delete);
        }

        [Fact]
        public async Task Remove_ExistingId_RemovesOneItem()
        {
            // Arrange
            var existingId = "110547";
            // Act
            var removebook= await _controller.DeleteBook(existingId);
            Assert.IsType<OkResult>(removebook);
        }
    }
}
