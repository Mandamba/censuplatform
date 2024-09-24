using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Census.Management.Application.DTOs.Responses.Person;
public record CreatePersonFunctionResponse
{
    public long FunctionId { get; set; }
    public string FunctionName { get; set; }
    public long PersonId { get; set; }
    public long CategoryId { get; set; }
    public string CategoryName { get; set; }
    public long DurationYear { get; set; }
    public CreatePersonFunctionResponse(long functionId, string functionName, long personId,
    long categoryId, string categoryName, int durationYear)
    {
        FunctionId = functionId;
        FunctionName = functionName;
        PersonId = personId;
        CategoryId = categoryId;
        CategoryName = categoryName;
        DurationYear = durationYear;
    }
}