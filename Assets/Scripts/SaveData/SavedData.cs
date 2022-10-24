﻿using System;
using System.Text;
using System.IO;
using UnityEngine;


    [Serializable]
    public sealed class SavedData
    {
        public string Name;
        public Vector3Serializable Position;
        public bool IsEnabled;

        public override string ToString() => $"Name {Name} Position {Position} IsVisible {IsEnabled}";
    }

    [Serializable]
    public struct Vector3Serializable
    {
        public float X;
        public float Y;
        public float Z;

        private Vector3Serializable(float valueX, float valueY, float valueZ)
        {
            X = valueX;
            Y = valueY;
            Z = valueZ;
        }

        public static implicit operator Vector3(Vector3Serializable value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }

        public static implicit operator Vector3Serializable(Vector3 value)
        {
            return new Vector3Serializable(value.x, value.y, value.z);
        }

        public override string ToString() => $"(X = {X} Y = {Y} Z = {Z})";
    }

