using NUnit.Framework;
using ConsoleApp;
using Challenge.DataContracts;

namespace Tests;

public class SolverTests
{
    [SetUp]
    public void Setup()
    {
        // Подготовка тестового окружения
        // Действия, которые будут выполнены перед каждым тестом
    }

    [Test]
    public void Solve_Returns42_Everytime()
    {
        var expected = "42";
        TaskResponse task = null;

        var actual = Solver.Solve(task);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TearDown]
    public void Teardown()
    {
        // Разборка тестового окружения
        // Действия, которые будут выполнены после каждого теста
    }
}
