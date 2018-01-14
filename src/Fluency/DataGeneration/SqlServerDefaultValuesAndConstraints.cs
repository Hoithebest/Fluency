// Copyright 2011 Chris Edwards
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;


namespace Fluency.DataGeneration
{
    public class SqlServerDefaultValuesAndConstraints : IValueConstraints, IDefaultValues
    {
        static readonly DateTime _minimumValidDateTimeForSqlServer = DateTime.Parse( @"1/1/1753 12:00:00 AM" );


        #region IDefaultValues Members

        public DateTime DefaultDateTime
        {
            get { return _minimumValidDateTimeForSqlServer; }
        }

        #endregion


        #region IValueConstraints Members

        public DateTime MaxDateTime
        {
            get { return DateTime.MaxValue; }
        }

        public DateTime MinDateTime
        {
            get { return _minimumValidDateTimeForSqlServer; }
        }

        #endregion
    }
}