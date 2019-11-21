﻿/*******************************************************************************
 * Copyright (c) 2013 IBM Corporation.
 *
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * and Eclipse Distribution License v. 1.0 which accompanies this distribution.
 *
 * The Eclipse Public License is available at http://www.eclipse.org/legal/epl-v10.html
 * and the Eclipse Distribution License is available at
 * http://www.eclipse.org/org/documents/edl-v10.php.
 *
 * Contributors:
 *     Steve Pitschke  - initial API and implementation
 *******************************************************************************/

namespace OSLC4Net.Core.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OSLC4Net.Core.Attribute;
    using OSLC4Net.Core.Model;

    [OslcResourceShape(title = "Architecture Management Resource Resource Shape", describes = new string[] { ArchitectureConstants.TYPE_ARCHITECTURE_RESOURCE })]
    [OslcNamespace(ArchitectureConstants.ARCHITECTURE_NAMESPACE)]
    /// <summary>
    /// http://open-services.net/wiki/architecture-management/OSLC-Architecture-Management-Specification-Version-2.0/
    /// </summary>
    public class ArchitectureResource : AbstractResource
    {
        private readonly ISet<Uri> _contributors = new HashSet<Uri>(); // XXX - TreeISet<> in Java
        private readonly ISet<Uri> _creators = new HashSet<Uri>(); // XXX - TreeISet<> in Java
        private readonly ISet<string> _dctermsTypes = new HashSet<string>(); // XXX - TreeISet<> in
        private readonly ISet<Uri> _rdfTypes = new HashSet<Uri>(); // XXX - TreeISet<> in Java

        private DateTime? _created;
        private string _description;
        private string _identifier;
        private Uri _source;
        private Uri _instanceShape;
        private DateTime? _modified;
        private Uri _serviceProvider;
        private string _title;

        public ArchitectureResource() : base()
        {
            this._rdfTypes.Add(new Uri(ArchitectureConstants.TYPE_ARCHITECTURE_RESOURCE));
        }

        public ArchitectureResource(Uri about) : base(about)
        {
            this._rdfTypes.Add(new Uri(ArchitectureConstants.TYPE_ARCHITECTURE_RESOURCE));
        }

        public void AddContributor(Uri contributor)
        {
            this._contributors.Add(contributor);
        }

        public void AddCreator(Uri creator)
        {
            this._creators.Add(creator);
        }

        public void AddRdfType(Uri rdfType)
        {
            this._rdfTypes.Add(rdfType);
        }

        public void AddDctermsType(string dctermsType)
        {
            this._dctermsTypes.Add(dctermsType);
        }

        [OslcDescription("The person(s) who are responsible for the work needed to complete the automation plan.")]
        [OslcName("contributor")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "contributor")]
        [OslcRange(QmConstants.TYPE_PERSON)]
        [OslcTitle("Contributors")]
        public Uri[] GetContributors()
        {
            return this._contributors.ToArray();
        }

        [OslcDescription("Timestamp of resource creation.")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "created")]
        [OslcReadOnly]
        [OslcTitle("Created")]
        public DateTime? GetCreated()
        {
            return this._created;
        }

        [OslcDescription("Creator or creators of resource.")]
        [OslcName("creator")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "creator")]
        [OslcRange(ArchitectureConstants.TYPE_PERSON)]
        [OslcTitle("Creators")]
        public Uri[] GetCreators()
        {
            return this._creators.ToArray();
        }

        [OslcDescription("Descriptive text (reference: Dublin Core) about resource represented as rich text in XHTML content.")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "description")]
        [OslcTitle("Description")]
        [OslcValueType(Core.Model.ValueType.XMLLiteral)]
        public string GetDescription()
        {
            return this._description;
        }

        [OslcDescription("A unique identifier for a resource. Assigned by the service provider when a resource is created. Not intended for end-user display.")]
        [OslcOccurs(Occurs.ExactlyOne)]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "identifier")]
        [OslcReadOnly]
        [OslcTitle("Identifier")]
        public string GetIdentifier()
        {
            return this._identifier;
        }

        [OslcDescription("Resource Shape that provides hints as to resource property value-types and allowed values. ")]
        [OslcPropertyDefinition(OslcConstants.OSLC_CORE_NAMESPACE + "instanceShape")]
        [OslcRange(OslcConstants.TYPE_RESOURCE_SHAPE)]
        [OslcTitle("Instance Shape")]
        public Uri GetInstanceShape()
        {
            return this._instanceShape;
        }

        [OslcDescription("Timestamp last latest resource modification.")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "modified")]
        [OslcReadOnly]
        [OslcTitle("Modified")]
        public DateTime? GetModified()
        {
            return this._modified;
        }

        [OslcDescription("The resource type Uris.")]
        [OslcName("type")]
        [OslcPropertyDefinition(OslcConstants.RDF_NAMESPACE + "type")]
        [OslcTitle("Types")]
        public Uri[] GetRdfTypes()
        {
            return this._rdfTypes.ToArray();
        }

        [OslcDescription("A short string representation for the type, example 'Defect'.")]
        [OslcName("type")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "type")]
        [OslcTitle("DCTerms Types")]
        public string[] GetDctermsTypes()
        {
            return this._dctermsTypes.ToArray();
        }

        [OslcDescription("The resource Uri a client can perform a Get on to obtain the original non-OSLC AM formatted resource that was used to create this resource. ")]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "source")]
        [OslcTitle("Source")]
        public Uri GetSource()
        {
            return this._source;
        }

        [OslcDescription("The scope of a resource is a Uri for the resource's OSLC Service Provider.")]
        [OslcPropertyDefinition(OslcConstants.OSLC_CORE_NAMESPACE + "serviceProvider")]
        [OslcRange(OslcConstants.TYPE_SERVICE_PROVIDER)]
        [OslcTitle("Service Provider")]
        public Uri GetServiceProvider()
        {
            return this._serviceProvider;
        }

        [OslcDescription("Title (reference: Dublin Core) or often a single line summary of the resource represented as rich text in XHTML content.")]
        [OslcOccurs(Occurs.ExactlyOne)]
        [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "title")]
        [OslcTitle("Title")]
        [OslcValueType(Core.Model.ValueType.XMLLiteral)]
        public string GetTitle()
        {
            return this._title;
        }

        public void SetContributors(Uri[] contributors)
        {
            this._contributors.Clear();

            if (contributors != null)
            {
                this._contributors.AddAll(contributors);
            }
        }

        public void SetCreated(DateTime? created)
        {
            this._created = created;
        }

        public void SetCreators(Uri[] creators)
        {
            this._creators.Clear();

            if (creators != null)
            {
                this._creators.AddAll(creators);
            }
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }

        public void SetIdentifier(string identifier)
        {
            this._identifier = identifier;
        }

        public void SetInstanceShape(Uri instanceShape)
        {
            this._instanceShape = instanceShape;
        }

        public void SetModified(DateTime? modified)
        {
            this._modified = modified;
        }

        public void SetRdfTypes(Uri[] rdfTypes)
        {
            this._rdfTypes.Clear();

            if (rdfTypes != null)
            {
                this._rdfTypes.AddAll(rdfTypes);
            }
        }

        public void SetDctermsTypes(string[] dctermsTypes)
        {
            this._dctermsTypes.Clear();

            if (dctermsTypes != null)
            {
                this._dctermsTypes.AddAll(dctermsTypes);
            }
        }

        public void SetSource(Uri source)
        {
            this._source = source;
        }

        public void SetServiceProvider(Uri serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public void SetTitle(string title)
        {
            this._title = title;
        }

        protected Uri GetRdfType()
        {
            return new Uri(ArchitectureConstants.TYPE_ARCHITECTURE_RESOURCE);
        }
    }
}