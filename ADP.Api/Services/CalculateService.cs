using ADP.Lib;
using ADP.Model.DTO;
using ADP.Model.Entity;

namespace ADP.Api.Services
{
    public static class CalculateService
    {
        public static ADPTaskDTO Calculate(ADPTask model)
        {
            var dto = new ADPTaskDTO();
            dto.Id = model.Id;

            dto.Result = model.Operation switch
            {
                "multiplication" => Calculator.Multiplication(model),
                "division" => Calculator.Division(model),
                "subtraction" => Calculator.Subtraction(model),
                "addition" => Calculator.Addition(model),
                "remainder" => Calculator.Remainder(model),
                _ => throw new Exception("Invalid operation: " + model.Operation)
            };

            return dto;
        }
    }
}
