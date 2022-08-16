using ADP.Lib;
using ADP.Model.DTO;
using ADP.Model.Entity;

namespace ADP.Api.Services
{
    public class TaskServices
    {
        private readonly Http _http;

        public TaskServices()
        {
            _http = new Http("https://interview.adpeai.com/api/v1/");
        }
        
        public async Task<ADPTask> GetTask()
        {
            return await _http.GetRequest<ADPTask>("get-task");
        }

        public async Task<RequestResult> PostTask(ADPTaskDTO dto) 
        { 
            return await _http.PostRequest<ADPTaskDTO>("submit-task", dto);
        }
    }
}
