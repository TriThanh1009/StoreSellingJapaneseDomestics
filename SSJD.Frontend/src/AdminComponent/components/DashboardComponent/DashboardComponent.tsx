import React from 'react';

import styles from './DashboardComponent.css';

export interface DashboardComponentProps {
  prop?: string;
}

export function DashboardComponent({prop = 'default value'}: DashboardComponentProps) {
  return <div className={styles.DashboardComponent}>DashboardComponent {prop}</div>;
}
