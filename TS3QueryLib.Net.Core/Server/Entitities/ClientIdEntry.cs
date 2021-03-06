﻿using System;
using TS3QueryLib.Net.Core.Common.CommandHandling;

namespace TS3QueryLib.Net.Core.Server.Entitities
{
    public class ClientIdEntry : IEntity<ClientIdEntry>
    {
        #region Properties

        public uint ClientId { get; protected set; }
        public string NickName { get; protected set; }

        #endregion

        #region Public Methods

        ClientIdEntry IEntity<ClientIdEntry>.ApplyFrom(CommandParameterGroup currentParameterGroup, CommandParameterGroup firstParameterGroup)
        { 
            if (currentParameterGroup == null)
                throw new ArgumentNullException(nameof(currentParameterGroup));
            
            ClientId = currentParameterGroup.GetParameterValue<uint>("clid");
            NickName = currentParameterGroup.GetParameterValue("name");

            return this;
        }

        #endregion
    }
}