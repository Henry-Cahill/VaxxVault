<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" indent="yes"/>
	<xsl:template match="/">
		<antigenSupportingData>
			<immunity>
				<xsl:value-of select="//immunity"/>
			</immunity>
			<contraindications>
				<xsl:for-each select="//contraindications/contraindication">
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
			<series>
				<xsl:for-each select="//series">
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
						<selectSeries>
							<defaultSeries>
								<xsl:value-of select="selectSeries/defaultSeries"/>
							</defaultSeries>
							<productPath>
								<xsl:value-of select="selectSeries/productPath"/>
							</productPath>
							<seriesGroupName>
								<xsl:value-of select="selectSeries/seriesGroupName"/>
							</seriesGroupName>
							<seriesGroup>
								<xsl:value-of select="selectSeries/seriesGroup"/>
							</seriesGroup>
							<seriesPriority>
								<xsl:value-of select="selectSeries/seriesPriority"/>
							</seriesPriority>
							<seriesPreference>
								<xsl:value-of select="selectSeries/seriesPreference"/>
							</seriesPreference>
							<minAgeToStart>
								<xsl:value-of select="selectSeries/minAgeToStart"/>
							</minAgeToStart>
							<maxAgeToStart>
								<xsl:value-of select="selectSeries/maxAgeToStart"/>
							</maxAgeToStart>
						</selectSeries>
						<indication>
							<observationCode>
								<xsl:value-of select="indication/observationCode"/>
							</observationCode>
							<description>
								<xsl:value-of select="indication/description"/>
							</description>
							<beginAge>
								<xsl:value-of select="indication/beginAge"/>
							</beginAge>
							<endAge>
								<xsl:value-of select="indication/endAge"/>
							</endAge>
							<guidance>
								<xsl:value-of select="indication/guidance"/>
							</guidance>
						</indication>
						<seriesDose>
							<doseNumber>
								<xsl:value-of select="seriesDose/doseNumber"/>
							</doseNumber>
							<absMinAge>
								<xsl:value-of select="seriesDose/absMinAge"/>
							</absMinAge>
							<minAge>
								<xsl:value-of select="seriesDose/minAge"/>
							</minAge>
							<earliestRecAge>
								<xsl:value-of select="seriesDose/earliestRecAge"/>
							</earliestRecAge>
						</seriesDose>
						<preferableVaccine>
							<xsl:for-each select="seriesDose/preferableVaccine">
								<vaccine>
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
								</vaccine>
							</xsl:for-each>
						</preferableVaccine>
						<allowableVaccine>
							<xsl:for-each select="seriesDose/allowableVaccine">
								<vaccine>
									<vaccineType>
										<xsl:value-of select="vaccineType"/>
									</vaccineType>
									<cvx>
										<xsl:value-of select="cvx"/>
									</cvx>
									<beginAge>
										<xsl:value-of select="beginAge"/>
									</beginAge>
								</vaccine>
							</xsl:for-each>
						</allowableVaccine>
					</seriesData>
				</xsl:for-each>
			</series>
		</antigenSupportingData>
	</xsl:template>
</xsl:stylesheet>