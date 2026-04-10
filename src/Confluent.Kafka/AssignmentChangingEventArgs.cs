using System;
using System.Collections.Generic;

namespace Confluent.Kafka
{
    /// <summary>
    ///     Provides data for the <see cref="IConsumer{TKey,TValue}.AssignmentChanging"/> event.
    ///     Raised on consumers when partition assignment is changing, either by direct assignment or by rebalance.
    /// </summary>
    public sealed class AssignmentChangingEventArgs : EventArgs
    {
        /// <summary>
        ///     Partitions being added to the assignment.
        ///     Empty when partitions are only being revoked.
        /// </summary>
        public IReadOnlyList<TopicPartitionOffset> AssignedPartitions { get; }

        /// <summary>
        ///     Partitions being removed from the assignment.
        ///     Empty when partitions are only being assigned.
        /// </summary>
        public IReadOnlyList<TopicPartition> RevokedPartitions { get; }

        internal AssignmentChangingEventArgs(
            IReadOnlyList<TopicPartitionOffset> assigned,
            IReadOnlyList<TopicPartition> revoked)
        {
            AssignedPartitions = assigned;
            RevokedPartitions = revoked;
        }
    }
}