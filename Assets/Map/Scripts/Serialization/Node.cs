﻿using System.Xml;
using UnityEngine;

namespace Maps
{
    public class Node
    {
        public ulong ID { get; private set; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }
        public float X { get; private set; }
        public float Y { get; private set; }

        public static implicit operator Vector3(Node node)
        {
            return new Vector3(node.X, 0, node.Y);
        }

        public Node(XmlNode node)
        {
            ID = XmlGetter.GetAttribute<ulong>("id", node.Attributes);
            Latitude = XmlGetter.GetAttribute<float>("lat", node.Attributes);
            Longitude = XmlGetter.GetAttribute<float>("lon", node.Attributes);
            X = (float)MercatorProjection.lonToX(Longitude);
            Y = (float)MercatorProjection.latToY(Latitude);
        }
    }
}