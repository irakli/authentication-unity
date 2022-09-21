﻿using System.Runtime.Serialization;

namespace Cdm.Authorization
{
    [DataContract]
    public class AccessTokenRequest
    {
        [DataMember(IsRequired = true, Name = "grant_type")]
        public string grantType => "authorization_code";
        
        /// <summary>
        /// REQUIRED. The authorization code received from the authorization server.
        /// </summary>
        [DataMember(IsRequired = true, Name = "code")]
        public string code { get; set; }
        
        /// <summary>
        /// REQUIRED, if the client is not authenticating with the authorization server as described in
        /// <a href="https://www.rfc-editor.org/rfc/rfc6749#section-3.2.1">Section 3.2.1</a>.
        /// </summary>
        [DataMember(IsRequired = true, Name = "client_id")]
        public string clientId { get; set; }
        
        /// <summary>
        /// The client secret.
        /// </summary>
        [DataMember(Name = "client_secret")]
        public string clientSecret { get; set; }
        
        /// <summary>
        /// REQUIRED, if the "redirect_uri" parameter was included in the authorization request as described in
        /// <a href="https://www.rfc-editor.org/rfc/rfc6749#section-4.1.1">Section 4.1.1</a>,
        /// and their values MUST be identical.
        /// </summary>
        [DataMember(Name = "redirect_uri")]
        public string redirectUri { get; set; }
    }
}