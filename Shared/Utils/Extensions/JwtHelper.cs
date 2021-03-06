﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace Utils.Extensions.Helper
{
    public class JwtClaim
    {
        public JwtClaim(string claim, string value)
        {
            this.Claim = claim;
            this.Value = value;
        }

        public string Claim { get; set; }
        public string Value { get; set; }
    }

    public class JwtHelper
    {
        public static List<JwtClaim> Decode(string header, string[] args)
        {
            var bearer = header.Split(' ')[1];

            var tokenDecoder = new JwtSecurityTokenHandler();
            var token = (JwtSecurityToken)tokenDecoder.ReadToken(bearer);

            List<JwtClaim> result = new List<JwtClaim>();

            foreach (string obj in args)
            {
                result.Add(new JwtClaim(obj, token.Claims.Where(x => x.Type == obj).Select(c => c.Value).SingleOrDefault()));
            }

            return result;
        }

        public static Dictionary<string, string> GetTokenValues(string header, string[] claimsIdentifications)
        {
            Dictionary<string, string> mappedClaimValues = new Dictionary<string, string>();

            List<JwtClaim> jwtClaims = Decode(header, claimsIdentifications);

            try
            {
                foreach(string claimId in claimsIdentifications)
                {
                    var claim = jwtClaims.Where(x => x.Claim == claimId).FirstOrDefault();
                    mappedClaimValues.Add(claimId, claim != null ? claim.Value : null);
                }
            }
            catch
            {

            }

            return mappedClaimValues;
        }
    }
}
