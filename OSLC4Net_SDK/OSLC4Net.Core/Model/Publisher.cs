﻿/*******************************************************************************
 * Copyright (c) 2012 IBM Corporation.
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OSLC4Net.Core.Attribute;

namespace OSLC4Net.Core.Model
{
    /// <summary>
    /// OSLC Publisher resource
    /// </summary>
    [OslcNamespace(OslcConstants.OSLC_CORE_NAMESPACE)]
    [OslcResourceShape(title = "OSLC Publisher Resource Shape", describes = new string[] { OslcConstants.TYPE_PUBLISHER })]
    public class Publisher : AbstractResource 
    {
	    private Uri    icon;
	    private String identifier;
	    private String label;
	    private String title;

	    public Publisher() : base()
        {
	    }

	    public Publisher(String title, String identifier) : this()
        {
		    this.title = title;
		    this.identifier = identifier;
	    }

	   [OslcDescription("URL to an icon file that represents the provider. This icon should be a favicon format and 16x16 pixels in size")]
	   [OslcPropertyDefinition(OslcConstants.OSLC_CORE_NAMESPACE + "icon")]
	   [OslcReadOnly]
       [OslcTitle("Icon")]
        public Uri GetIcon() {
	        return icon;
	    }

	   [OslcDescription("A URN that uniquely identifies the implementation")]
	   [OslcOccurs(Occurs.ExactlyOne)]
	   [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "identifier")]
	   [OslcReadOnly] // TODO - Marked as unspecified in the spec, but is this correct?
	   [OslcTitle("Identifier")]
	    public String GetIdentifier() {
		    return identifier;
	    }

	   [OslcDescription("Very short label for use in menu items")]
	   [OslcPropertyDefinition(OslcConstants.OSLC_CORE_NAMESPACE + "label")]
	   [OslcReadOnly]
       [OslcTitle("Label")]
	    public String GetLabel() {
		    return label;
	    }

	   [OslcDescription("Title string that could be used for display")]
       [OslcOccurs(Occurs.ExactlyOne)]
	   [OslcPropertyDefinition(OslcConstants.DCTERMS_NAMESPACE + "title")]
	   [OslcReadOnly]
       [OslcTitle("Title")]
       [OslcValueType(ValueType.XMLLiteral)]
	    public String GetTitle() {
		    return title;
	    }

	    public void SetIcon(Uri icon) {
	        this.icon = icon;
	    }

	    public void SetIdentifier(String identifier) {
		    this.identifier = identifier;
	    }

	    public void SetLabel(String label) {
		    this.label = label;
	    }

	    public void SetTitle(String title) {
		    this.title = title;
	    }
    }
}
