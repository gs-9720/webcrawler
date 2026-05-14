export interface AuditReportModel {
  url: string
  pageType: number
  structure: Structure
  contentClarity: ContentClarity
  conversion: Conversion
  technical: Technical
  score: number
}

export interface Structure {
  title: string
  metaDescription: string
  h1s: string[]
  h2s: string[]
  internalLinks: string[]
  ctas: Cta[]
}

export interface Cta {
  text: string
  target: string
  aboveFold: boolean
}

export interface ContentClarity {
  valuePropAboveFold: boolean
  audienceType: string
  benefitFeatureRatio: number
}

export interface Conversion {
  primaryCtaAboveFold: boolean
  hasSecondaryCtas: boolean
  hasContactForm: boolean
  pricingVisible: boolean
}

export interface Technical {
  isHttps: boolean
  hasCanonical: boolean
  mobileFriendly: boolean
  pageLoadMs: number
}
