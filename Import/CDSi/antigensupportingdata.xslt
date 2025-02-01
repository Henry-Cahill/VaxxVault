<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" indent="yes"/>
    
    <!-- Template to match the root element -->
    <xsl:template match="/">
        <antigenSupportingData>
            <xsl:apply-templates select="//immunity"/>
            <xsl:apply-templates select="//contraindications"/>
            <xsl:apply-templates select="//series"/>
        </antigenSupportingData>
    </xsl:template>
    
    <!-- Template to handle immunity -->
    <xsl:template match="immunity">
        <immunity>
            <xsl:copy-of select="*"/>
        </immunity>
    </xsl:template>
    
    <!-- Template to handle contraindications -->
    <xsl:template match="contraindications">
        <contraindications>
            <xsl:for-each select="vaccineGroup/contraindication | vaccine/contraindication">
                <contraindication>
                    <observationCode>
                        <xsl:value-of select="observationCode"/>
                    </observationCode>
                    <observationTitle>
                        <xsl:value-of select="observationTitle"/>
                    </observationTitle>
                    <contraindicationText>
                        <xsl:value-of select="contraindicationText"/>
                    </contraindicationText>
                </contraindication>
            </xsl:for-each>
        </contraindications>
    </xsl:template>
    
    <!-- Template to handle series -->
    <xsl:template match="series">
        <seriesData>
            <seriesName>
                <xsl:value-of select="seriesName"/>
            </seriesName>
            <targetDisease>
                <xsl:value-of select="targetDisease"/>
            </targetDisease>
            <vaccineGroup>
                <xsl:value-of select="vaccineGroup"/>
            </vaccineGroup>
            <seriesType>
                <xsl:value-of select="seriesType"/>
            </seriesType>
            <seriesAdminGuidance>
                <xsl:value-of select="seriesAdminGuidance"/>
            </seriesAdminGuidance>
            <xsl:apply-templates select="selectSeries"/>
            <xsl:apply-templates select="indication"/>
            <xsl:apply-templates select="seriesDose"/>
        </seriesData>
    </xsl:template>
    
    <!-- Template to handle selectSeries -->
    <xsl:template match="selectSeries">
        <selectSeries>
            <defaultSeries>
                <xsl:value-of select="defaultSeries"/>
            </defaultSeries>
            <productPath>
                <xsl:value-of select="productPath"/>
            </productPath>
            <seriesGroupName>
                <xsl:value-of select="seriesGroupName"/>
            </seriesGroupName>
            <seriesGroup>
                <xsl:value-of select="seriesGroup"/>
            </seriesGroup>
            <seriesPriority>
                <xsl:value-of select="seriesPriority"/>
            </seriesPriority>
            <seriesPreference>
                <xsl:value-of select="seriesPreference"/>
            </seriesPreference>
            <minAgeToStart>
                <xsl:value-of select="minAgeToStart"/>
            </minAgeToStart>
            <maxAgeToStart>
                <xsl:value-of select="maxAgeToStart"/>
            </maxAgeToStart>
        </selectSeries>
    </xsl:template>
    
    <!-- Template to handle indication -->
    <xsl:template match="indication">
        <indication>
            <observationCode>
                <xsl:value-of select="observationCode"/>
            </observationCode>
            <description>
                <xsl:value-of select="description"/>
            </description>
            <beginAge>
                <xsl:value-of select="beginAge"/>
            </beginAge>
            <endAge>
                <xsl:value-of select="endAge"/>
            </endAge>
            <guidance>
                <xsl:value-of select="guidance"/>
            </guidance>
        </indication>
    </xsl:template>
    
    <!-- Template to handle seriesDose -->
    <xsl:template match="seriesDose">
        <seriesDose>
            <doseNumber>
                <xsl:value-of select="doseNumber"/>
            </doseNumber>
            <absMinAge>
                <xsl:value-of select="age/absMinAge"/>
            </absMinAge>
            <minAge>
                <xsl:value-of select="age/minAge"/>
            </minAge>
            <earliestRecAge>
                <xsl:value-of select="age/earliestRecAge"/>
            </earliestRecAge>
            <xsl:apply-templates select="preferableVaccine"/>
            <xsl:apply-templates select="allowableVaccine"/>
        </seriesDose>
    </xsl:template>
    
    <!-- Template to handle preferableVaccine -->
    <xsl:template match="preferableVaccine">
        <preferableVaccine>
            <vaccineType>
                <xsl:value-of select="vaccineType"/>
            </vaccineType>
            <cvx>
                <xsl:value-of select="cvx"/>
            </cvx>
            <beginAge>
                <xsl:value-of select="beginAge"/>
            </beginAge>
            <endAge>
                <xsl:value-of select="endAge"/>
            </endAge>
            <volume>
                <xsl:value-of select="volume"/>
            </volume>
        </preferableVaccine>
    </xsl:template>
    
    <!-- Template to handle allowableVaccine -->
    <xsl:template match="allowableVaccine">
        <allowableVaccine>
            <vaccineType>
                <xsl:value-of select="vaccineType"/>
            </vaccineType>
            <cvx>
                <xsl:value-of select="cvx"/>
            </cvx>
            <beginAge>
                <xsl:value-of select="beginAge"/>
            </beginAge>
        </allowableVaccine>
    </xsl:template>
</xsl:stylesheet>
