using System.Collections.Generic;
namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<CompetitionInvite> responses = new List<CompetitionInvite>();
        public static IEnumerable<CompetitionInvite> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(CompetitionInvite response)
        {
            responses.Add(response);
        }
    }
}