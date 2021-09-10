// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Docs.Admin.Documents;

// ReSharper disable once CheckNamespace
namespace Volo.Docs.Admin.ClientProxies
{
    public partial class DocumentsAdminClientProxy
    {
        public virtual async Task ClearCacheAsync(ClearCacheInput input)
        {
            await RequestAsync(nameof(ClearCacheAsync), input);
        }

        public virtual async Task PullAllAsync(PullAllDocumentInput input)
        {
            await RequestAsync(nameof(PullAllAsync), input);
        }

        public virtual async Task PullAsync(PullDocumentInput input)
        {
            await RequestAsync(nameof(PullAsync), input);
        }

        public virtual async Task<PagedResultDto<DocumentDto>> GetAllAsync(GetAllInput input)
        {
            return await RequestAsync<PagedResultDto<DocumentDto>>(nameof(GetAllAsync), input);
        }

        public virtual async Task RemoveFromCacheAsync(Guid documentId)
        {
            await RequestAsync(nameof(RemoveFromCacheAsync), documentId);
        }

        public virtual async Task ReindexAsync(Guid documentId)
        {
            await RequestAsync(nameof(ReindexAsync), documentId);
        }
    }
}
