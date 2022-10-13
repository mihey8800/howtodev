import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'howtodev',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44367/',
    redirectUri: baseUrl,
    clientId: 'howtodev_App',
    responseType: 'code',
    scope: 'offline_access howtodev',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44367',
      rootNamespace: 'howtodev',
    },
  },
} as Environment;