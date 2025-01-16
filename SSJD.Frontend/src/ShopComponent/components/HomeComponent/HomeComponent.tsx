/* eslint-disable @typescript-eslint/no-unused-vars */
import React from 'react';

import styles from './HomeComponent.css';

export interface HomeComponentProps {
  prop?: string;
}

export function HomeComponent({prop = 'default value'}: HomeComponentProps) {
  return <div></div>;
}
