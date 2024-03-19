    public class Repository
    {
        private readonly string projectId;
        private readonly string repositoryId;
        private readonly string locationId;

        public Repository(string projectId, string repositoryId, string locationId)
        {
            this.projectId = projectId;
            this.repositoryId = repositoryId;
            this.locationId = locationId;
        }

        public string Name => $"projects/{projectId}/locations/{locationId}/repositories/{repositoryId}";
    }  
