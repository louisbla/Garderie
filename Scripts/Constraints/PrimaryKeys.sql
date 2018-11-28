USE Garderie
GO

ALTER TABLE Activites
ADD CONSTRAINT PK__Activite__BE3FB9853DF1AB3E PRIMARY KEY (ActiviteId);
GO

ALTER TABLE Adresses
ADD CONSTRAINT PK__Adresses__C3F7F274B07A63C5 PRIMARY KEY (AdresseId)
GO

ALTER TABLE Articles
ADD 
	CONSTRAINT PK__Articles__9C6270E86CCA9D36 PRIMARY KEY (ArticleId);
GO

ALTER TABLE Calendriers
ADD 
    CONSTRAINT PK__Calendri__9887DD02824FA395 PRIMARY KEY (CalendrierId,EmployeId);
GO

ALTER TABLE CategoriesArticle
ADD CONSTRAINT PK__Categori__F643ADA6BEC3AFF7 PRIMARY KEY (CategorieId);
GO

ALTER TABLE ComptesUser
ADD 
	CONSTRAINT PK__ComptesU__CB9A1CFFB04D1BAB PRIMARY KEY (UserId);
GO

ALTER TABLE Conges
ADD 
    CONSTRAINT PK__Conges__3D850D5401CE68C6 PRIMARY KEY (CongeId);
GO

ALTER TABLE ContactsUrgence
ADD 
    CONSTRAINT PK__Contacts__5C66259B44088F58 PRIMARY KEY (ContactId);	
GO

ALTER TABLE DocumentsOfficiels
ADD
	CONSTRAINT PK__Document__1ABEEF0FF425F164 PRIMARY KEY (DocumentId); 
GO

ALTER TABLE DossiersContactUrgence
ADD 
    CONSTRAINT PK__Dossiers__F1E672BBE4CF75AB PRIMARY KEY (DossierContactUrgenceId);
GO

ALTER TABLE DossiersEmploye
ADD 
    CONSTRAINT PK__Dossiers__CABB1D90C28ED71E PRIMARY KEY (DossierId);
GO

ALTER TABLE DossiersInscription
ADD 
    CONSTRAINT PK__Dossiers__CABB1D901723AD71 PRIMARY KEY (DossierId);
GO

ALTER TABLE EmployeGroupes
ADD 
    CONSTRAINT PK__EmployeG__BAA40F12157AFC20 PRIMARY KEY (GroupeId,EmployeId);
GO

ALTER TABLE Employes
ADD 
    CONSTRAINT PK__Employes__6251442F73E5D9BB PRIMARY KEY (EmployeId);
GO

ALTER TABLE Enfants
ADD 
    CONSTRAINT PK__Enfants__7EA0D282EB4EFF06 PRIMARY KEY (EnfantId);
GO

ALTER TABLE Factures
ADD 
    CONSTRAINT PK__Factures__511BBA6044177D33 PRIMARY KEY (FactureId);
GO

ALTER TABLE FichesPaye
ADD
    CONSTRAINT PK__FichesPa__792D82E0B9DC25B0 PRIMARY KEY (FichePayeId);
GO

ALTER TABLE Filiations
ADD
    CONSTRAINT PK__Filiatio__883F8580388F6236 PRIMARY KEY (ParentId,EnfantId);
GO

ALTER TABLE Groupes
ADD
	CONSTRAINT PK__Groupes__5C811B5066F22F0E PRIMARY KEY (GroupeId);
GO

ALTER TABLE Horaires
ADD
    CONSTRAINT PK__Horaires__7AB2D2F8A2192989 PRIMARY KEY (HoraireId,CalendrierId);
GO

ALTER TABLE Inventaires
ADD
    CONSTRAINT PK__Inventai__70BCB462052A7A8F PRIMARY KEY (InventaireId);
GO

ALTER TABLE InventairesEnfant
ADD
	CONSTRAINT PK__Inventai__70BCB462C5F0EFEE PRIMARY KEY (InventaireId);
GO

ALTER TABLE Lieux
ADD
	CONSTRAINT PK__Lieux__B921CDFFB6099003 PRIMARY KEY (SalleId);
GO

ALTER TABLE LignesFactures
ADD
    CONSTRAINT PK__LignesFa__2E582795B0F82FB8 PRIMARY KEY (LigneId,FactureId);
GO

ALTER TABLE Maladies
ADD
	CONSTRAINT PK__Maladies__EFA7066B1996EAF0 PRIMARY KEY (MaladieId);
GO

ALTER TABLE ObjetsFacturables
ADD
    CONSTRAINT PK__ObjetsFa__6ABEE1A2E1BA6025 PRIMARY KEY (ObjetFacturableId);
GO

ALTER TABLE Parents
ADD
    CONSTRAINT PK__Parents__D339516F054AFB97 PRIMARY KEY (ParentId);
GO

ALTER TABLE ParentsFactures
ADD
    CONSTRAINT PK__ParentsF__CAE6E2EA266E5CC9 PRIMARY KEY (FactureId,ParentId);
GO

ALTER TABLE Participation
ADD
    CONSTRAINT PK__Particip__554E89FD1DCE001D PRIMARY KEY (ActiviteId,GroupeId,SalleId);
GO

ALTER TABLE PersonneAdresses
ADD
	CONSTRAINT PK__Personne__580AAAFEBD221665 PRIMARY KEY (AdresseId,PersonneId);
GO

ALTER TABLE Personnes
ADD
	CONSTRAINT PK__Personne__BFD588A8ADA9FFDF PRIMARY KEY (PersonneId);
GO

ALTER TABLE RapportJournalier
ADD
    CONSTRAINT PK__RapportJ__6C3B9CBB664E707F PRIMARY KEY (RapportId);
GO

ALTER TABLE StatutsFacture
ADD
	CONSTRAINT PK__StatutsF__CA32066AE12E7537 PRIMARY KEY (StatutFactureId);
GO

ALTER TABLE TVAs
ADD
	CONSTRAINT PK__TVAs__7AB21A1251FDCCE4 PRIMARY KEY (TVAId);
GO

ALTER TABLE Traitements
ADD
	CONSTRAINT PK__Traiteme__D84D0B436F8C2B12 PRIMARY KEY (MaladieId,EnfantId);
GO

ALTER TABLE TypesConges
ADD
	CONSTRAINT PK__TypesCon__9CA372ADBDBA9FE4 PRIMARY KEY (TypeCongeId);    
GO

ALTER TABLE TypesContrat
ADD
	CONSTRAINT PK__TypesCon__516F03B537D9F3BA PRIMARY KEY (TypeContratId);    
GO

ALTER TABLE TypesGroupe
ADD
	CONSTRAINT PK__TypesGro__2DF338883008B05F PRIMARY KEY (TypeGroupeId);    
GO