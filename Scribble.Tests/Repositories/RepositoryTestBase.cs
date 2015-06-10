using Raven.Client;
using Raven.Client.Embedded;

namespace Scribble.Tests.Repositories
{
    public class RepositoryTestBase
    {
        protected static IDocumentSession WithEmptySession()
        {
            var store = new EmbeddableDocumentStore
            {
                RunInMemory = true
            }.Initialize();

            return store.OpenSession();
        }
    }
}