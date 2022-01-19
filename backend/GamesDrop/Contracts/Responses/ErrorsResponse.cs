using System.Collections.Generic;

namespace GamesDrop.Contracts.Responses
{
    public class ErrorsResponse
    {
        public ErrorsResponse(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public ErrorsResponse(string error)
        {
            Errors = new[] {error};
        }

        public IEnumerable<string> Errors { get; set; }
    }
}