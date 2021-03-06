﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using System.Collections.Generic;
using OpenNos.DAL.Interface;
using OpenNos.Data;
using System.Linq;

namespace OpenNos.DAL.Mock
{
    public class MapDAO : BaseDAO<MapDTO>, IMapDAO
    {
        #region Methods

        public MapDTO LoadById(short mapId)
        {
            return Container.SingleOrDefault(c => c.MapId.Equals(mapId));
        }

        public void Insert(List<MapDTO> maps)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}