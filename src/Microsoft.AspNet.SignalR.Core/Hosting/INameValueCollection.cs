﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNet.SignalR.Hosting
{
    public interface INameValueCollection : IEnumerable<KeyValuePair<string, string>>
    {
        string this[string key] { get; }
        IEnumerable<string> GetValues(string key);

        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get", Justification = "We're matching the name value collection API for compatibility")]
        string Get(string key);
    }
}
