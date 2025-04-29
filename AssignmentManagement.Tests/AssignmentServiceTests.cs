namespace AssignmentManagement.Tests
{
    using AssignmentManagement.Core;
    using Xunit;
    public class AssignmentServiceTests
    {
        [Fact]
        public void ListIncomplete_ShouldReturnOnlyAssignmentsThatAreNotCompleted()
        {
            // Arrange
            var service = new AssignmentService();
            var a1 = new Assignment("Incomplete Task", "Do something");
            var a2 = new Assignment("Completed Task", "Do something else");
            a2.MarkComplete();

            service.AddAssignment(a1);
            service.AddAssignment(a2);

            // Act
            var result = service.ListIncomplete();

            // Assert
            // This will fail until students implement ListIncomplete()
            Assert.Single(result);
            Assert.Equal("Incomplete Task", result[0].Title);
        }

        [Fact]
        public void FindAssignmentByTitle_ShouldReturnCorrectAssignment()
        {
            // Arrange
            var service = new AssignmentService();
            var assignment = new Assignment("Test Title", "Test Description");
            service.AddAssignment(assignment);

            // Act
            var result = service.FindAssignmentByTitle("Test Title");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Title", result.Title);
        }
    }
}
