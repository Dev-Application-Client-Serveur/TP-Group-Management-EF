using AppGestionStagiaires.Data;
using AppGestionStagiaires.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGestionStagiaires.Services
{
    /// <summary>
    /// Les données sont enregistrer dans une liste des groupes
    /// La minipulation des données est gérer avec Linq
    /// </summary>
    public class GroupsService
    {
        private AppModel _Context; 

        public GroupsService()
        {
            _Context = new AppModel();
        }
        /// <summary>
        /// Add new Group
        /// </summary>
        /// <param name="g"> le Groupe à ajouter</param>
        public void Add(Group g) {
            this._Context.Groups.Add(g);
            this._Context.SaveChanges();
        }

        /// <summary>
        /// Supprimer un groupe par Id
        /// </summary>
        /// <param name="id"> Id de groupe à supprimer</param>
        public void Delete(int id) {
            var db_group = this._Context.Groups.Find(id);
            if (db_group != null)
            {
                _Context.Groups.Remove(db_group);
                _Context.SaveChanges();
            }
    
        }

        /// <summary>
        /// Mise à jour un objet Groupe
        /// </summary>
        /// <param name="g">un objet de type groupe contenant les information à mettre à jour</param>
        public void Update(Group g) {
            var db_group = this._Context.Groups.Find(g.Id);
            if (db_group != null)
            {
                db_group.Nom = g.Nom;
                _Context.SaveChanges();
            }
        }
        /// <summary>
        /// Retourne la liste des groupes à afficher
        /// </summary>
        /// <returns></returns>
        public List<Group> FindAll() {
           return  _Context.Groups.ToList();
        }
    }
}
