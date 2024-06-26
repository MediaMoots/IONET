﻿using IONET.Core;
using IONET.Core.Model;
using System;
using System.IO;

namespace IONET.Fbx
{
    public class FbxImporter : ISceneLoader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public IOScene GetScene(string filePath)
        {
            FbxHelper helper = new FbxHelper(FbxIO.ReadBinary(filePath));


            //TODO: FBX Version 2006-2010 unupported. (Anything < 7100 works. But textures aren't grabbed)
            //FBX Version 2011-2020 <-- Tested & Supported!
            //FBX Version 2011-2020 currently supported
            if (helper.Version < 7100)
                throw new NotSupportedException($"FBX Version {helper.Version} not supported");

            IOScene scene = new IOScene();

            IOModel model = new IOModel();
            model.Skeleton = helper.GetSkeleton();
            scene.Models.Add(model);

            model.Meshes.AddRange(helper.ExtractMesh());
            
            scene.Materials.AddRange(helper.GetMaterials());

            return scene;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetExtensions()
        {
            return new string[] { ".fbx" };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Autodesk FBX";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool Verify(string filePath)
        {
            return Path.GetExtension(filePath).ToLower().Equals(".fbx");
        }
    }
}
